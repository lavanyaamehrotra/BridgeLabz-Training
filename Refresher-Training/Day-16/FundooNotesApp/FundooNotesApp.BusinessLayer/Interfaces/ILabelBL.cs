using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.BusinessLayer.Interfaces
{
    public interface ILabelBL
    {
        LabelModel CreateLabel(CreateLabelDTO createLabelDTO, int userId);
        LabelModel GetLabelById(int labelId, int userId);
        List<LabelModel> GetAllLabels(int userId);
        LabelModel EditLabel(int labelId, int userId, EditLabelDTO editLabelDTO);
        void DeleteLabel(int labelId, int userId);
    }
}