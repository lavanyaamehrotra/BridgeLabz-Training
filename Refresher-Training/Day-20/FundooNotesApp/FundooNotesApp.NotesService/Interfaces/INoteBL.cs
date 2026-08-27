using FundooNotesApp.NotesService.DTOs;
using FundooNotesApp.NotesService.Models;

namespace FundooNotesApp.NotesService.Interfaces
{
    public interface INoteBL
    {
        NoteModel CreateNote(CreateNoteDTO createNoteDTO, int userId);
        List<NoteModel> GetAllNotes(int userId);
        NoteModel GetNoteById(int noteId, int userId);
        NoteModel? GetNoteByIdInternal(int noteId);
        void DeleteNote(int noteId, int userId);
        NoteModel TogglePin(int noteId, int userId);
        NoteModel ToggleArchive(int noteId, int userId);
        NoteModel TrashNote(int noteId, int userId);
        NoteModel RestoreNote(int noteId, int userId);
        List<NoteModel> SearchNotes(int userId, string keyword);
        List<NoteModel> FilterNotesByText(int userId, string searchText);
    }
}
