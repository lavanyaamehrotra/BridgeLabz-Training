using FundooNotesApp.UserManagementService.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.UserManagementService.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext>options):base(options){}
    public DbSet<UserEntity>Users{get;set;}
}
