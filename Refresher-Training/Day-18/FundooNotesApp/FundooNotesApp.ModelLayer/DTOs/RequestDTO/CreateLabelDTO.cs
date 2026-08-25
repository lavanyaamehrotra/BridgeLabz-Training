using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.DTOs.RequestDTO
{
    public class CreateLabelDTO
    {
        [Required(ErrorMessage = "LabelName is required")]
        [MaxLength(50)]
        public string LabelName { get; set; } = string.Empty;

        [Required(ErrorMessage = "NoteId is required")]
        public int NoteId { get; set; }
    }
}