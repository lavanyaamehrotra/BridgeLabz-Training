using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ReminderService.Models
{
    public class ReminderEntity
    {
        [Key]
        public int ReminderId { get; set; }

        [Required]
        public DateTime ReminderTime { get; set; }

        public int NoteId { get; set; }
        public int UserId { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public bool IsSent { get; set; } = false;
    }
}
