using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.UserManagementService.DTOs.RequestDTO;
    public class ResetPasswordDTO
    {
        [Required(ErrorMessage = "Reset token is required")]
        public string Token{get; set;}="";


        [Required(ErrorMessage = "New password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        [MaxLength(20, ErrorMessage = "Password cannot exceed 20 characters")]
        public string NewPassword{get; set;}="";
    }
