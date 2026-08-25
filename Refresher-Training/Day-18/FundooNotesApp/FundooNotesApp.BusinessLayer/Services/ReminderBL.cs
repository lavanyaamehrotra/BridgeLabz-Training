using FundooNotesApp.BusinessLayer.Interfaces;
using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.ModelLayer.Exceptions;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Interfaces;

namespace FundooNotesApp.BusinessLayer.Services
{
    public class ReminderBL : IReminderBL
    {
        private readonly IReminderRL _reminderRL;

        public ReminderBL(IReminderRL reminderRL)
        {
            _reminderRL = reminderRL;
        }

        public ReminderModel CreateReminder(CreateReminderDTO createReminderDTO, int userId)
        {
            var reminderEntity = new ReminderEntity
            {
                NoteId = createReminderDTO.NoteId,
                ReminderTime = createReminderDTO.ReminderTime,
                UserId = userId
            };

            var saved = _reminderRL.CreateReminder(reminderEntity);
            return MapToModel(saved);
        }

        public List<ReminderModel> GetAllReminders(int userId)
        {
            var reminders = _reminderRL.GetAllReminders(userId);
            return reminders.Select(MapToModel).ToList();
        }

        public void DeleteReminder(int reminderId, int userId)
        {
            bool deleted = _reminderRL.DeleteReminder(reminderId, userId);
            if (!deleted)
            {
                throw new ReminderNotFoundException("Reminder not found or you don't have permission to delete it");
            }
        }

        private static ReminderModel MapToModel(ReminderEntity r)
        {
            return new ReminderModel
            {
                ReminderId = r.ReminderId,
                NoteId = r.NoteId,
                ReminderTime = r.ReminderTime
            };
        }
    }
}