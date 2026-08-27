using FundooNotesApp.AuthService.DTOs;

namespace FundooNotesApp.AuthService.Interfaces
{
    public interface IAuthBL
    {
        string Register(RegisterRequest request);
        string Login(LoginRequest request);
    }
}
