using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Interfaces;

namespace FundooNotesApp.BusinessLayer.Services
{
    public class LabelBL : ILabelBL
    {
        private readonly ILabelRL _labelRL;

        public LabelBL(ILabelRL labelRL)
        {
            _labelRL = labelRL;
        }

        public LabelModel CreateLabel(CreateLabelDTO createLabelDTO, int userId)
        {
            var labelEntity = new LabelEntity
            {
                LabelName = createLabelDTO.LabelName,
                NoteId = createLabelDTO.NoteId,
                UserId = userId
            };

            var saved = _labelRL.CreateLabel(labelEntity);
            return MapToModel(saved);
        }

        public LabelModel GetLabelById(int labelId, int userId)
        {
            var label = _labelRL.GetLabelById(labelId, userId);
            if (label == null)
            {
                throw new LabelNotFoundException("Label not found or you don't have permission to view it");
            }
            return MapToModel(label);
        }

        public List<LabelModel> GetAllLabels(int userId)
        {
            var labels = _labelRL.GetAllLabels(userId);
            return labels.Select(MapToModel).ToList();
        }

        public LabelModel EditLabel(int labelId, int userId, EditLabelDTO editLabelDTO)
        {
            var label = _labelRL.EditLabel(labelId, userId, editLabelDTO.LabelName);
            if (label == null)
            {
                throw new LabelNotFoundException("Label not found or you don't have permission to edit it");
            }
            return MapToModel(label);
        }

        public void DeleteLabel(int labelId, int userId)
        {
            bool deleted = _labelRL.DeleteLabel(labelId, userId);
            if (!deleted)
            {
                throw new LabelNotFoundException("Label not found or you don't have permission to delete it");
            }
        }

        private static LabelModel MapToModel(LabelEntity l)
        {
            return new LabelModel
            {
                LabelId = l.LabelId,
                LabelName = l.LabelName,
                NoteId = l.NoteId
            };
        }
    }
}