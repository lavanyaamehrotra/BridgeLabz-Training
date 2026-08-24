using FundooNotesApp.ModelLayer.Entities;

namespace FundooNotesApp.RepositoryLayer.Interfaces
{
    public interface IReminderRL
    {
        ReminderEntity CreateReminder(ReminderEntity reminder);
        List<ReminderEntity> GetAllReminders(int userId);
        ReminderEntity? GetReminderById(int reminderId, int userId);
        bool DeleteReminder(int reminderId, int userId);
    }
}