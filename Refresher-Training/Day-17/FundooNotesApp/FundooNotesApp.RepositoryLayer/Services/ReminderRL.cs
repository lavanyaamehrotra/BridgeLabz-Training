using FundooNotesApp.ModelLayer.Entities;
using FundooNotesApp.RepositoryLayer.Context;
using FundooNotesApp.RepositoryLayer.Interfaces;

namespace FundooNotesApp.RepositoryLayer.Services
{
    public class ReminderRL : IReminderRL
    {
        private readonly FundooContext _context;

        public ReminderRL(FundooContext context)
        {
            _context = context;
        }

        public ReminderEntity CreateReminder(ReminderEntity reminder)
        {
            _context.Reminders.Add(reminder);
            _context.SaveChanges();
            return reminder;
        }

        public List<ReminderEntity> GetAllReminders(int userId)
        {
            return _context.Reminders
                .Where(r => r.UserId == userId)
                .OrderBy(r => r.ReminderTime)
                .ToList();
        }

        public ReminderEntity? GetReminderById(int reminderId, int userId)
        {
            return _context.Reminders.FirstOrDefault(r => r.ReminderId == reminderId && r.UserId == userId);
        }

        public bool DeleteReminder(int reminderId, int userId)
        {
            var reminder = _context.Reminders.FirstOrDefault(r => r.ReminderId == reminderId && r.UserId == userId);
            if (reminder == null) return false;

            _context.Reminders.Remove(reminder);
            _context.SaveChanges();
            return true;
        }
    }
}