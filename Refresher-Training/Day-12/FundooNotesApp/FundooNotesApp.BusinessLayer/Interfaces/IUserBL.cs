using FundooNotesApp.ModelLayer.DTOs.RequestDTO;

namespace FundooNotesApp.BusinessLayer.Interfaces;
public interface IUserBL
{
    string Register(RegistrationDTO registrationDTO);
    string Login(LoginDTO loginDTO);
    string ForgetPassword(ForgotPasswordDTO forgetPasswordDTO);
    string ResetPassword(ResetPasswordDTO resetPasswordDTO);
}
