using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FundooNotesApp.RepositoryLayer.Services
{
    public class NoteRL : INoteRL
    {
        private readonly FundooContext _context;

        public NoteRL(FundooContext context)
        {
            _context = context;
        }

        public NoteEntity CreateNote(NoteEntity note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note;
        }

        public List<NoteEntity> GetAllNotes(int userId)
        {
            return _context.Notes.Where(n => n.UserId == userId && !n.Trash).ToList();
        }

        public NoteEntity? GetNoteById(int noteId, int userId)
        {
            return _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
        }
        public bool DeleteNote(int noteId, int userId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note == null)
            {
                return false;
            }

            _context.Notes.Remove(note);
            _context.SaveChanges();
            return true;
        }
    }
}