using FundooNotesApp.ModelLayer.DTOs.RequestDTO;
using FundooNotesApp.ModelLayer.Models;

namespace FundooNotesApp.BusinessLayer.Interfaces
{
    public interface IReminderBL
    {
        ReminderModel CreateReminder(CreateReminderDTO createReminderDTO, int userId);
        List<ReminderModel> GetAllReminders(int userId);
        void DeleteReminder(int reminderId, int userId);
    }
}