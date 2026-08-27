using FundooNotesApp.AuthService.Data;
using FundooNotesApp.AuthService.Interfaces;
using FundooNotesApp.AuthService.Models;

namespace FundooNotesApp.AuthService.Repositories
{
    public class AuthRL : IAuthRL
    {
        private readonly AuthDbContext _context;

        public AuthRL(AuthDbContext context)
        {
            _context = context;
        }

        public UserEntity Register(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserEntity? GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
