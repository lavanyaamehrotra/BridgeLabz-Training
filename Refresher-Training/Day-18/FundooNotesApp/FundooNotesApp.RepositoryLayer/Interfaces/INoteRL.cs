using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interfaces
{
    public interface INoteRL
    {
        NoteEntity CreateNote(NoteEntity note);
        List<NoteEntity> GetAllNotes(int userId);
        NoteEntity? GetNoteById(int noteId, int userId);
        bool DeleteNote(int noteId, int userId);

        NoteEntity? TogglePin(int noteId, int userId);
        NoteEntity? ToggleArchive(int noteId, int userId);
        NoteEntity? TrashNote(int noteId, int userId);
        NoteEntity? RestoreNote(int noteId, int userId);
        List<NoteEntity> SearchNotes(int userId, string keyword);
        List<NoteEntity> FilterNotesByText(int userId, string searchText);
    }
}