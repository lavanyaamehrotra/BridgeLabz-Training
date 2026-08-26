using FundooNotesApp.UserManagementService.Entities;
using FundooNotesApp.UserManagementService.Models;

namespace FundooNotesApp.UserManagementService.Interfaces;

public interface IUserRL
{
    UserModel Register(UserEntity user);
    UserEntity? GetUserByEmail(string email);
    UserEntity? GetUserByResetToken(string token);
    UserEntity UpdateUser(UserEntity user);
}
