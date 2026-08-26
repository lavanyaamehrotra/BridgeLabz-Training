using FundooNotesApp.UserManagementService.DTOs.RequestDTO;

namespace FundooNotesApp.UserManagementService.Interfaces;
public interface IUserBL
{
    string Register(RegistrationDTO registrationDTO);
    string Login(LoginDTO loginDTO);
    string ForgetPassword(ForgotPasswordDTO forgetPasswordDTO);
    string ResetPassword(ResetPasswordDTO resetPasswordDTO);
    void Logout(string email);
}
