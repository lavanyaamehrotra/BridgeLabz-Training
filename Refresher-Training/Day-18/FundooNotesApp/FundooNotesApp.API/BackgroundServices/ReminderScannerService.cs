using FundooNotesApp.BusinessLayer.Helpers;
using FundooNotesApp.ModelLayer.Models;
using FundooNotesApp.RepositoryLayer.Context;

namespace FundooNotesApp.API.BackgroundServices
{
    public class ReminderScannerService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly RabbitMQPublisher _publisher;

        public ReminderScannerService(IServiceScopeFactory scopeFactory, RabbitMQPublisher publisher)
        {
            _scopeFactory = scopeFactory;
            _publisher = publisher;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<FundooContext>();

                    var dueReminders = context.Reminders
                        .Where(r => !r.IsSent && r.ReminderTime <= DateTime.UtcNow)
                        .ToList();

                    foreach (var reminder in dueReminders)
                    {
                        var note = context.Notes.FirstOrDefault(n => n.NoteId == reminder.NoteId);
                        var user = context.Users.FirstOrDefault(u => u.UserId == reminder.UserId);

                        if (note != null && user != null)
                        {
                            var message = new EmailQueueMessage
                            {
                                ToEmail = user.Email,
                                Subject = $"Reminder: {note.Title}",
                                NoteTitle = note.Title,
                                NoteDescription = note.Description,
                                ReminderId = reminder.ReminderId
                            };

                           await _publisher.PublishEmailMessageAsync(message);

                            reminder.IsSent = true; // mark so we don't send it again
                        }
                    }

                    context.SaveChanges();
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken); // check every 1 minute
            }
        }
    }
}