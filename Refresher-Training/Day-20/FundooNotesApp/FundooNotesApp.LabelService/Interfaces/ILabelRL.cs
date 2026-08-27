using FundooNotesApp.LabelService.Models;

namespace FundooNotesApp.LabelService.Interfaces
{
    public interface ILabelRL
    {
        LabelEntity CreateLabel(LabelEntity label);
        LabelEntity? GetLabelById(int labelId, int userId);
        List<LabelEntity> GetAllLabels(int userId);
        LabelEntity? EditLabel(int labelId, int userId, string newLabelName);
        bool DeleteLabel(int labelId, int userId);
    }
}
