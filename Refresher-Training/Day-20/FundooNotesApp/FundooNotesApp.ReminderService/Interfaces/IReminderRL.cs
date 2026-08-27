using FundooNotesApp.ReminderService.Models;

namespace FundooNotesApp.ReminderService.Interfaces
{
    public interface IReminderRL
    {
        ReminderEntity CreateReminder(ReminderEntity reminder);
        List<ReminderEntity> GetAllReminders(int userId);
        ReminderEntity? GetReminderById(int reminderId, int userId);
        bool DeleteReminder(int reminderId, int userId);
    }
}
