using System.ComponentModel.DataAnnotations;

namespace FundooNotesApp.ModelLayer.DTOs.RequestDTO;

public class ForgotPasswordDTO
{
    [Required(ErrorMessage ="Email is Reqired")]
    [EmailAddress(ErrorMessage ="Enter a valid Email Address")]
    public string Email{get;set;}="";
}