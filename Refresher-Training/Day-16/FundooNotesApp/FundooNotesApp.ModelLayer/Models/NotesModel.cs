namespace FundooNotesApp.ModelLayer.Models
{
    public class NoteModel
    {
        public int NoteId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? Reminder { get; set; }
        public string? BackgroundColor { get; set; }
        public bool Archive { get; set; }
        public bool Pin { get; set; }
        public bool Trash { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }
    }
}