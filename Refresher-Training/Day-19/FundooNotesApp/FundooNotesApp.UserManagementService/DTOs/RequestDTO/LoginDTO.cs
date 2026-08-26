using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.UserManagementService.DTOs.RequestDTO;

public class LoginDTO
{
    
    [Required(ErrorMessage ="Email is Required")]
    [EmailAddress(ErrorMessage ="Enter a valid Email Address")]
    public string Email{get;set;}="";

    [Required(ErrorMessage ="Password is Required")]
    public string Password{get;set;}="";
}
