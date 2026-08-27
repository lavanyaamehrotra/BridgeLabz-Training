using FundooNotesApp.ReminderService.DTOs;
using FundooNotesApp.ReminderService.Models;

namespace FundooNotesApp.ReminderService.Interfaces
{
    public interface IReminderBL
    {
        ReminderModel CreateReminder(CreateReminderDTO createReminderDTO, int userId);
        List<ReminderModel> GetAllReminders(int userId);
        void DeleteReminder(int reminderId, int userId);
    }
}
