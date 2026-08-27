using FundooNotesApp.LabelService.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.LabelService.Data
{
    public class LabelDbContext : DbContext
    {
        public LabelDbContext(DbContextOptions<LabelDbContext> options) : base(options) { }

        public DbSet<LabelEntity> Labels { get; set; }
    }
}
