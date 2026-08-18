using FundooNotesApp.BusinessLayer.Helpers;
using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.RepositoryLayer.Interfaces;

namespace FundooNotesApp.BusinessLayer.Services
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL _userRL;
        private readonly JwtTokenHelper _jwtTokenHelper;

        public UserBL(IUserRL userRL, JwtTokenHelper jwtTokenHelper)
        {
            _userRL = userRL;
            _jwtTokenHelper = jwtTokenHelper;
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

            return _jwtTokenHelper.GenerateToken(user.UserId, user.Email);
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
    }
}