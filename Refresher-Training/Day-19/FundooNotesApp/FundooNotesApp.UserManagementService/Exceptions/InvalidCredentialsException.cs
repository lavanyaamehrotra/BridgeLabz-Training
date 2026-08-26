namespace FundooNotesApp.UserManagementService.Exceptions;
public class InvalidCredentialsException : Exception
{
    public InvalidCredentialsException(string message) : base(message) { }
}
