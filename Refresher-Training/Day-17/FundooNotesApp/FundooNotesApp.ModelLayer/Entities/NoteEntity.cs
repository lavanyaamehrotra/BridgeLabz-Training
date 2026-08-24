using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundooNotesApp.ModelLayer.Entities
{
    public class NoteEntity
    {
        [Key]
        public int NoteId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        // public DateTime? Reminder { get; set; }

        [MaxLength(20)]
        public string? BackgroundColor { get; set; }

        public bool Archive { get; set; } = false;
        public bool Pin { get; set; } = false;
        public bool Trash { get; set; } = false;

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Edited { get; set; }

        // Links this note to the user who owns it
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}