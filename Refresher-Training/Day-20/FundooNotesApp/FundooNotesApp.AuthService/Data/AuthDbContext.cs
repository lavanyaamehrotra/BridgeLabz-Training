using FundooNotesApp.AuthService.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.AuthService.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
    }
}
