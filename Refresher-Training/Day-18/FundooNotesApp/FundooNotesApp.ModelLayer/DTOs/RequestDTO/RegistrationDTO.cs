using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.DTOs.RequestDTO;

public class RegistrationDTO
{
    
    [Required(ErrorMessage="First Name is Required")]
    [MaxLength(50)]
    public string FirstName{get;set;}="";

    [MaxLength(50)]
    public string LastName{get;set;}="";

    [Required(ErrorMessage = "Email is Required")]
    [EmailAddress(ErrorMessage ="Enter a valid email address")]
    public string Email{get;set;}="";

    [Required(ErrorMessage ="Password is Required")]
    [MinLength(6, ErrorMessage ="Password must be atleast 6 characters Long")]
    [MaxLength(20,ErrorMessage ="Password cannot exceed 20 characters")]
    public string Password{get;set;}="";

}