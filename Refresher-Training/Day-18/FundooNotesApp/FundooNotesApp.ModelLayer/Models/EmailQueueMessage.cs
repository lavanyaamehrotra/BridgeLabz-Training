namespace FundooNotesApp.ModelLayer.Models
{
    public class EmailQueueMessage
    {
        public string ToEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string NoteTitle { get; set; } = string.Empty;
        public string NoteDescription { get; set; } = string.Empty;
        public int ReminderId { get; set; }
    }
}