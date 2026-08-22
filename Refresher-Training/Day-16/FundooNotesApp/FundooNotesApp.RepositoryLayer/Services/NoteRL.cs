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
            if (note == null || !note.Trash)
            {
                return false; // doesn't exist, isn't theirs, OR isn't in trash yet
            }

            _context.Notes.Remove(note);
            _context.SaveChanges();
            return true;
        }
        public NoteEntity? TogglePin(int noteId, int userId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note == null) return null;

            note.Pin = !note.Pin; // flip true <-> false
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public NoteEntity? ToggleArchive(int noteId, int userId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note == null) return null;

            note.Archive = !note.Archive;
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public NoteEntity? TrashNote(int noteId, int userId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note == null) return null;

            note.Trash = true;
            note.Pin = false;      // trashing clears pin
            note.Archive = false;  // trashing clears archive
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }

        public NoteEntity? RestoreNote(int noteId, int userId)
        {
            var note = _context.Notes.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note == null) return null;

            note.Trash = false; // back to normal, in main view - not re-pinned or re-archived automatically
            note.Edited = DateTime.UtcNow;
            _context.SaveChanges();
            return note;
        }
        
        public List<NoteEntity> SearchNotes(int userId, string keyword)
        {
            return _context.Notes
                .Where(n => n.UserId == userId && !n.Trash && n.Title.Contains(keyword))
                .ToList();
        }
        public List<NoteEntity> FilterNotesByText(int userId, string searchText)
        {
            return _context.Notes
                .Where(n => n.UserId == userId && !n.Trash &&
                            (n.Title.Contains(searchText) || n.Description.Contains(searchText)))
                .ToList();
        }
        
    }
}