using FundooNotesApp.ModelLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.RepositoryLayer.Context;

public class FundooContext : DbContext
{
    public FundooContext(DbContextOptions<FundooContext>options):base(options){}
    public DbSet<UserEntity>Users{get;set;}
     public DbSet<NoteEntity>Notes{get;set;}
     public DbSet<LabelEntity> Labels { get; set; }
     public DbSet<ReminderEntity> Reminders { get; set; }
}