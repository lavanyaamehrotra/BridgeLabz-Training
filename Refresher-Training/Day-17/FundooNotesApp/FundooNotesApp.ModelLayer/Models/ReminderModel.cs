namespace FundooNotesApp.ModelLayer.Models
{
    public class ReminderModel
    {
        public int ReminderId { get; set; }
        public int NoteId { get; set; }
        public DateTime ReminderTime { get; set; }
    }
}