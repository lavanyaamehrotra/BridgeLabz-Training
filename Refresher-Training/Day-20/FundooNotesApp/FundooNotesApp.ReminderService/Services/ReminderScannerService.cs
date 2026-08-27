using System.Net.Http.Json;
using FundooNotesApp.ReminderService.Data;
using FundooNotesApp.ReminderService.DTOs;
using FundooNotesApp.ReminderService.Helpers;
using FundooNotesApp.ReminderService.Models;

namespace FundooNotesApp.ReminderService.Services
{
    public class ReminderScannerService : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly EmailSender _emailSender;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ReminderScannerService> _logger;
        private readonly IConfiguration _config;

        public ReminderScannerService(
            IServiceScopeFactory scopeFactory,
            EmailSender emailSender,
            IHttpClientFactory httpClientFactory,
            ILogger<ReminderScannerService> logger,
            IConfiguration config)
        {
            _scopeFactory = scopeFactory;
            _emailSender = emailSender;
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var notesServiceUrl = _config["Services:NotesServiceUrl"] ?? "http://localhost:5003";
            var userServiceUrl = _config["Services:UserServiceUrl"] ?? "http://localhost:5002";

            _logger.LogInformation("[Reminder & Notification Service] Starting background scanner and notification engine...");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var context = scope.ServiceProvider.GetRequiredService<ReminderDbContext>();
                        context.Database.EnsureCreated();
                        var client = _httpClientFactory.CreateClient();

                        var dueReminders = context.Reminders
                            .Where(r => !r.IsSent && r.ReminderTime <= DateTime.UtcNow)
                            .ToList();

                        if (dueReminders.Count > 0)
                        {
                            _logger.LogInformation($"[Reminder & Notification Service] Found {dueReminders.Count} due reminder(s). Processing notifications...");
                        }

                        foreach (var reminder in dueReminders)
                        {
                            try
                            {
                                var noteResponse = await client.GetFromJsonAsync<ResponseDTO<NoteInternalDTO>>($"{notesServiceUrl}/api/notes/internal/{reminder.NoteId}", stoppingToken);
                                var userResponse = await client.GetFromJsonAsync<ResponseDTO<UserInternalDTO>>($"{userServiceUrl}/api/user/internal/{reminder.UserId}", stoppingToken);

                                if (noteResponse?.Data != null && userResponse?.Data != null)
                                {
                                    _logger.LogInformation($"[Notification Engine] Delivering reminder email to {userResponse.Data.Email} for Note: '{noteResponse.Data.Title}'");

                                    _emailSender.SendReminderEmail(
                                        userResponse.Data.Email,
                                        $"Reminder: {noteResponse.Data.Title}",
                                        noteResponse.Data.Title,
                                        noteResponse.Data.Description
                                    );

                                    _logger.LogInformation($"[Notification Engine] SUCCESS: Email notification sent to {userResponse.Data.Email}");
                                    reminder.IsSent = true;
                                }
                            }
                            catch (Exception ex)
                            {
                                _logger.LogWarning($"[Reminder & Notification Service] Email delivery warning: {ex.Message}");
                            }
                        }

                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogDebug($"[Reminder & Notification Service] Scanner status check: {ex.Message}");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
