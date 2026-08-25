using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.DTOs.RequestDTO
{
    public class CreateReminderDTO
    {
        [Required(ErrorMessage = "NoteId is required")]
        public int NoteId { get; set; }

        [Required(ErrorMessage = "ReminderTime is required")]
        public DateTime ReminderTime { get; set; }
    }
}