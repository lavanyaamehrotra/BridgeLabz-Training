using FundooNotesApp.NotesService.DTOs;
using FundooNotesApp.NotesService.Interfaces;
using FundooNotesApp.NotesService.Models;

namespace FundooNotesApp.NotesService.Services
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
                throw new KeyNotFoundException("Note not found or you don't have permission to view it");
            }
            return MapToModel(note);
        }

        public NoteModel? GetNoteByIdInternal(int noteId)
        {
            var note = _noteRL.GetNoteByIdInternal(noteId);
            return note == null ? null : MapToModel(note);
        }

        public void DeleteNote(int noteId, int userId)
        {
            bool deleted = _noteRL.DeleteNote(noteId, userId);
            if (!deleted)
            {
                throw new KeyNotFoundException("Note not found or you don't have permission to delete it");
            }
        }

        public NoteModel TogglePin(int noteId, int userId)
        {
            var note = _noteRL.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new KeyNotFoundException("Note not found or you don't have permission to update it");
            }

            if (note.Trash)
            {
                throw new InvalidOperationException("Cannot pin a note that is in trash");
            }

            if (!note.Pin && note.Archive)
            {
                _noteRL.ToggleArchive(noteId, userId);
            }

            var updated = _noteRL.TogglePin(noteId, userId);
            return MapToModel(updated!);
        }

        public NoteModel ToggleArchive(int noteId, int userId)
        {
            var note = _noteRL.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new KeyNotFoundException("Note not found or you don't have permission to update it");
            }

            if (note.Trash)
            {
                throw new InvalidOperationException("Cannot archive a note that is in trash");
            }

            if (!note.Archive && note.Pin)
            {
                _noteRL.TogglePin(noteId, userId);
            }

            var updated = _noteRL.ToggleArchive(noteId, userId);
            return MapToModel(updated!);
        }

        public NoteModel TrashNote(int noteId, int userId)
        {
            var note = _noteRL.TrashNote(noteId, userId);
            if (note == null)
            {
                throw new KeyNotFoundException("Note not found or you don't have permission to update it");
            }
            return MapToModel(note);
        }

        public NoteModel RestoreNote(int noteId, int userId)
        {
            var note = _noteRL.RestoreNote(noteId, userId);
            if (note == null)
            {
                throw new KeyNotFoundException("Note not found or you don't have permission to update it");
            }
            return MapToModel(note);
        }

        public List<NoteModel> SearchNotes(int userId, string keyword)
        {
            var notes = _noteRL.SearchNotes(userId, keyword);
            return notes.Select(MapToModel).ToList();
        }

        public List<NoteModel> FilterNotesByText(int userId, string searchText)
        {
            var notes = _noteRL.FilterNotesByText(userId, searchText);
            return notes.Select(MapToModel).ToList();
        }

        private static NoteModel MapToModel(NoteEntity n)
        {
            return new NoteModel
            {
                NoteId = n.NoteId,
                Title = n.Title,
                Description = n.Description,
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
