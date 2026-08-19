using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.BusinessLayer.Interfaces
{
    public interface INoteBL
    {
        NoteModel CreateNote(CreateNoteDTO createNoteDTO, int userId);
        List<NoteModel> GetAllNotes(int userId);
        NoteModel GetNoteById(int noteId, int userId);
        void DeleteNote(int noteId, int userId);
    }
}