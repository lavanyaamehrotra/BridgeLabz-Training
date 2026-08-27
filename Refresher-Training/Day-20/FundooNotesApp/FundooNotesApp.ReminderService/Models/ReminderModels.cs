namespace FundooNotesApp.ReminderService.Models
{
    public class ReminderModel
    {
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public DateTime ReminderTime { get; set; }
    }

    public class EmailQueueMessage
    {
        public string ToEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string NoteTitle { get; set; } = string.Empty;
        public string NoteDescription { get; set; } = string.Empty;
        public int ReminderId { get; set; }
    }
}
