using FundooNotesApp.UserManagementService.Entities;
using FundooNotesApp.UserManagementService.Models;
using FundooNotesApp.UserManagementService.Data;
using FundooNotesApp.UserManagementService.Interfaces;

namespace FundooNotesApp.UserManagementService.Repositories;

public class UserRL : IUserRL
{
    private readonly UserContext _context;

    public UserRL(UserContext context)
    {
        _context=context;
    }

    public UserModel Register(UserEntity user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return new UserModel
        {
            UserId=user.UserId,
            FirstName=user.FirstName,
            LastName=user.LastName,
            Email=user.Email
        };
    }
    public UserEntity? GetUserByEmail(string email)
    {
        return _context.Users.FirstOrDefault(u=>u.Email.ToLower()==email.ToLower());
    }
    public UserEntity? GetUserByResetToken(string token)
    {
        return _context.Users.FirstOrDefault(u=>u.ResetToken==token);
    }
    public UserEntity UpdateUser(UserEntity user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
        return user;
    }
}
