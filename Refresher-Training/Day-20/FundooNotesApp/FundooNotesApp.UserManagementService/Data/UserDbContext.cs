using FundooNotesApp.UserManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.UserManagementService.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
    }
}
