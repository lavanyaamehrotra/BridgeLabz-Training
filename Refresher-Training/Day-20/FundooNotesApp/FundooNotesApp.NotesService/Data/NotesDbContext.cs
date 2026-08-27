using FundooNotesApp.NotesService.Models;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.NotesService.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }

        public DbSet<NoteEntity> Notes { get; set; }
    }
}
