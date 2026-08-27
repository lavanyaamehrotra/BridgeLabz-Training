using FundooNotesApp.AuthService.Models;

namespace FundooNotesApp.AuthService.Interfaces
{
    public interface IAuthRL
    {
        UserEntity Register(UserEntity user);
        UserEntity? GetUserByEmail(string email);
    }
}
