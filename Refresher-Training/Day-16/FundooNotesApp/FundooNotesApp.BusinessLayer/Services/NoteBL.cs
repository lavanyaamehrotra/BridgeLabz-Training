using System;
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
        public NoteModel TogglePin(int noteId, int userId)
        {
            var note = _noteRL.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to update it");
            }

            if (note.Trash)
            {
                throw new InvalidOperationException("Cannot pin a note that is in trash");
            }

            // Pinning a note automatically un-archives it (pin and archive are mutually exclusive)
            if (!note.Pin && note.Archive)
            {
                _noteRL.ToggleArchive(noteId, userId); // un-archive first
            }

            var updated = _noteRL.TogglePin(noteId, userId);
            return MapToModel(updated!);
        }

        public NoteModel ToggleArchive(int noteId, int userId)
        {
            var note = _noteRL.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to update it");
            }

            if (note.Trash)
            {
                throw new InvalidOperationException("Cannot archive a note that is in trash");
            }

            // Archiving a note automatically un-pins it (pin and archive are mutually exclusive)
            if (!note.Archive && note.Pin)
            {
                _noteRL.TogglePin(noteId, userId); // un-pin first
            }

            var updated = _noteRL.ToggleArchive(noteId, userId);
            return MapToModel(updated!);
        }

        public NoteModel TrashNote(int noteId, int userId)
        {
            var note = _noteRL.TrashNote(noteId, userId);
            if (note == null)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to update it");
            }
            return MapToModel(note);
        }

        public NoteModel RestoreNote(int noteId, int userId)
        {
            var note = _noteRL.RestoreNote(noteId, userId);
            if (note == null)
            {
                throw new NoteNotFoundException("Note not found or you don't have permission to update it");
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
    }
}