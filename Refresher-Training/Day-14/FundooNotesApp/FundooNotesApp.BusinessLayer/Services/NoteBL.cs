using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Interfaces;

namespace FundooNotesApp.BusinessLayer.Services
{
    public class NoteBL : INoteBL
    {
        private readonly INoteRL _noteRL;

        public NoteBL(INoteRL noteRL)
        {
            _noteRL = noteRL;
        }

        public NoteModel CreateNote(CreateNoteDTO createNoteDTO, int userId)
        {
            var noteEntity = new NoteEntity
            {
                Title = createNoteDTO.Title,
                Description = createNoteDTO.Description,
                Reminder = createNoteDTO.Reminder,
                BackgroundColor = createNoteDTO.BackgroundColor,
                UserId = userId
            };

            var savedNote = _noteRL.CreateNote(noteEntity);
            return MapToModel(savedNote);
        }

        public List<NoteModel> GetAllNotes(int userId)
        {
            var notes = _noteRL.GetAllNotes(userId);
            return notes.Select(MapToModel).ToList();
        }

        public NoteModel GetNoteById(int noteId, int userId)
        {
            var note = _noteRL.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to view it");
            }
            return MapToModel(note);
        }

        public void DeleteNote(int noteId, int userId)
        {
            bool deleted = _noteRL.DeleteNote(noteId, userId);
            if (!deleted)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to delete it");
            }
        }

        // small private helper so we don't repeat this mapping in three places
        private static NoteModel MapToModel(NoteEntity n)
        {
            return new NoteModel
            {
                NoteId = n.NoteId,
                Title = n.Title,
                Description = n.Description,
                Reminder = n.Reminder,
                BackgroundColor = n.BackgroundColor,
                Archive = n.Archive,
                Pin = n.Pin,
                Trash = n.Trash,
                Created = n.Created,
                Edited = n.Edited
            };
        }
    }
}