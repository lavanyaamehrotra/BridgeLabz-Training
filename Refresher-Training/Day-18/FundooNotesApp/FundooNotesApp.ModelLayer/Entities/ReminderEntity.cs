using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundooNotesApp.ModelLayer.Entities
{
    public class ReminderEntity
    {
        [Key]
        public int ReminderId { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public bool IsSent { get; set; } = false;
    }
}