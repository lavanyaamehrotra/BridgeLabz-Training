using FundooNotesApp.LabelService.Data;
using FundooNotesApp.LabelService.Interfaces;
using FundooNotesApp.LabelService.Models;

namespace FundooNotesApp.LabelService.Repositories
{
    public class LabelRL : ILabelRL
    {
        private readonly LabelDbContext _context;

        public LabelRL(LabelDbContext context)
        {
            _context = context;
        }

        public LabelEntity CreateLabel(LabelEntity label)
        {
            _context.Labels.Add(label);
            _context.SaveChanges();
            return label;
        }

        public LabelEntity? GetLabelById(int labelId, int userId)
        {
            return _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
        }

        public List<LabelEntity> GetAllLabels(int userId)
        {
            return _context.Labels.Where(l => l.UserId == userId).ToList();
        }

        public LabelEntity? EditLabel(int labelId, int userId, string newLabelName)
        {
            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
            if (label == null) return null;

            label.LabelName = newLabelName;
            _context.SaveChanges();
            return label;
        }

        public bool DeleteLabel(int labelId, int userId)
        {
            var label = _context.Labels.FirstOrDefault(l => l.LabelId == labelId && l.UserId == userId);
            if (label == null) return false;

            _context.Labels.Remove(label);
            _context.SaveChanges();
            return true;
        }
    }
}
