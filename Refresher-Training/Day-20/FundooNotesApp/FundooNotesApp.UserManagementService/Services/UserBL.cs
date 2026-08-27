using FundooNotesApp.UserManagementService.DTOs;
using FundooNotesApp.UserManagementService.Helpers;
using FundooNotesApp.UserManagementService.Interfaces;
using FundooNotesApp.UserManagementService.Models;

namespace FundooNotesApp.UserManagementService.Services
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL _userRL;

        public UserBL(IUserRL userRL)
        {
            _userRL = userRL;
        }

        public string Register(RegistrationDTO registrationDTO)
        {
            var existingUser = _userRL.GetUserByEmail(registrationDTO.Email);
            if (existingUser != null)
            {
                throw new Exception("A user with this email already exists");
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

        public UserEntity ValidateUserForLogin(LoginDTO loginDTO)
        {
            var user = _userRL.GetUserByEmail(loginDTO.Email);
            if (user == null)
            {
                throw new KeyNotFoundException("No account found with this email");
            }

            bool isPasswordValid = PasswordEncryption.VerifyPassword(loginDTO.Password, user.PasswordHash);
            if (!isPasswordValid)
            {
                throw new UnauthorizedAccessException("Incorrect password");
            }

            return user;
        }

        public string ForgetPassword(ForgotPasswordDTO forgetPasswordDTO)
        {
            var user = _userRL.GetUserByEmail(forgetPasswordDTO.Email);
            if (user == null)
            {
                throw new KeyNotFoundException("No account found with this email");
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
                throw new UnauthorizedAccessException("Reset link is invalid or has expired");
            }

            string hashedPassword = PasswordEncryption.HashPassword(resetPasswordDTO.NewPassword);
            user.PasswordHash = hashedPassword;
            user.ResetToken = null;
            user.ResetTokenExpiry = null;

            _userRL.UpdateUser(user);
            return "Password has been reset successfully";
        }

        public UserEntity? GetUserById(int userId)
        {
            return _userRL.GetUserById(userId);
        }
    }
}
