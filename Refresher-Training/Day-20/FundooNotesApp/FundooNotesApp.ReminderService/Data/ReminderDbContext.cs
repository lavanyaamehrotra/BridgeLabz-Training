using FundooNotesApp.ReminderService.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.ReminderService.Data
{
    public class ReminderDbContext : DbContext
    {
        public ReminderDbContext(DbContextOptions<ReminderDbContext> options) : base(options) { }

        public DbSet<ReminderEntity> Reminders { get; set; }
    }
}
