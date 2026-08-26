namespace FundooNotesApp.UserManagementService.Exceptions;
public class UserAlreadyExistsException : Exception
{
    public UserAlreadyExistsException(string message):base(message){}
}
