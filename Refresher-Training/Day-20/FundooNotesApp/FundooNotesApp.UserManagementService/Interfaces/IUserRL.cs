using FundooNotesApp.UserManagementService.Models;

namespace FundooNotesApp.UserManagementService.Interfaces
{
    public interface IUserRL
    {
        UserModel Register(UserEntity user);
        UserEntity? GetUserByEmail(string email);
        UserEntity? GetUserById(int userId);
        UserEntity? GetUserByResetToken(string token);
        UserEntity UpdateUser(UserEntity user);
    }
}
