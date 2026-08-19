using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interfaces
{
    public interface INoteRL
    {
        NoteEntity CreateNote(NoteEntity note);
        List<NoteEntity> GetAllNotes(int userId);
        NoteEntity? GetNoteById(int noteId, int userId);
        bool DeleteNote(int noteId, int userId);
    }
}