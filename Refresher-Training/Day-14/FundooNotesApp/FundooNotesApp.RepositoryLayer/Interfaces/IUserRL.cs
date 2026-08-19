using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.RepositoryLayer.Interfaces;

public interface IUserRL
{
    UserModel Register(UserEntity user);
    UserEntity? GetUserByEmail(string email);
    UserEntity? GetUserByResetToken(string token);
    UserEntity UpdateUser(UserEntity user);
}