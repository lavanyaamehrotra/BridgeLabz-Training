using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.DTOs.RequestDTO
{
    public class EditLabelDTO
    {
        [Required(ErrorMessage = "LabelName is required")]
        [MaxLength(50)]
        public string LabelName { get; set; } = string.Empty;
    }
}