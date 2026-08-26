using FundooNotesApp.UserManagementService.Helpers;
using FundooNotesApp.UserManagementService.Interfaces;
using FundooNotesApp.UserManagementService.DTOs.RequestDTO;
using FundooNotesApp.UserManagementService.Entities;
using FundooNotesApp.UserManagementService.Exceptions;

namespace FundooNotesApp.UserManagementService.Services
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL _userRL;
        private readonly JwtTokenHelper _jwtTokenHelper;

        private readonly RedisCacheHelper _redisCacheHelper;

        public UserBL(IUserRL userRL, JwtTokenHelper jwtTokenHelper, RedisCacheHelper redisCacheHelper)
        {
            _userRL = userRL;
            _jwtTokenHelper = jwtTokenHelper;
            _redisCacheHelper = redisCacheHelper;
        }

        public string Register(RegistrationDTO registrationDTO)
        {
            var existingUser = _userRL.GetUserByEmail(registrationDTO.Email);
            if (existingUser != null)
            {
                throw new UserAlreadyExistsException("A user with this email already exists");
            }

            string hashedPassword = PasswordEncryption.HashPassword(registrationDTO.Password);

            var newUser = new UserEntity
            {
                FirstName = registrationDTO.FirstName,
                LastName = registrationDTO.LastName,
                Email = registrationDTO.Email,
                PasswordHash = hashedPassword
            };

            _userRL.Register(newUser);
            return "Registration successful";
        }

        public string Login(LoginDTO loginDTO)
        {
            var user = _userRL.GetUserByEmail(loginDTO.Email);
            if (user == null)
            {
                throw new UserNotFoundException("No account found with this email");
            }

            bool isPasswordValid = PasswordEncryption.VerifyPassword(loginDTO.Password, user.PasswordHash);
            if (!isPasswordValid)
            {
                throw new InvalidCredentialsException("Incorrect password");
            }

            string token = _jwtTokenHelper.GenerateToken(user.UserId, user.Email);

            // store the token in Redis, matching the JWT's own 2-hour expiry
            _redisCacheHelper.StoreToken(user.Email, token, TimeSpan.FromHours(2));

            return token;
        }

        public string ForgetPassword(ForgotPasswordDTO forgetPasswordDTO)
        {
            var user = _userRL.GetUserByEmail(forgetPasswordDTO.Email);
            if (user == null)
            {
                throw new UserNotFoundException("No account found with this email");
            }

            string resetToken = Guid.NewGuid().ToString("N");
            user.ResetToken = resetToken;
            user.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(30);

            _userRL.UpdateUser(user);

            return resetToken;
        }

        public string ResetPassword(ResetPasswordDTO resetPasswordDTO)
        {
            var user = _userRL.GetUserByResetToken(resetPasswordDTO.Token);
            if (user == null || user.ResetTokenExpiry == null || user.ResetTokenExpiry < DateTime.UtcNow)
            {
                throw new InvalidCredentialsException("Reset link is invalid or has expired");
            }

            string hashedPassword = PasswordEncryption.HashPassword(resetPasswordDTO.NewPassword);
            user.PasswordHash = hashedPassword;
            user.ResetToken = null;
            user.ResetTokenExpiry = null;

            _userRL.UpdateUser(user);
            return "Password has been reset successfully";
        }
        public void Logout(string email)
        {
            _redisCacheHelper.RemoveToken(email);
        }
    }
}
