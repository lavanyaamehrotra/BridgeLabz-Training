using FundooNotesApp.UserManagementService.DTOs;
using FundooNotesApp.UserManagementService.Models;

namespace FundooNotesApp.UserManagementService.Interfaces
{
    public interface IUserBL
    {
        string Register(RegistrationDTO registrationDTO);
        UserEntity ValidateUserForLogin(LoginDTO loginDTO);
        string ForgetPassword(ForgotPasswordDTO forgetPasswordDTO);
        string ResetPassword(ResetPasswordDTO resetPasswordDTO);
        UserEntity? GetUserById(int userId);
    }
}
