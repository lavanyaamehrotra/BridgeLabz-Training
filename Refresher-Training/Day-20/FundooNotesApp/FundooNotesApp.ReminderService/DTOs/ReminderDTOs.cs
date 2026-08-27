namespace FundooNotesApp.ReminderService.DTOs
{
    public class CreateReminderDTO
    {
        public int NoteId { get; set; }
        public DateTime ReminderTime { get; set; }
    }

    public class ResponseDTO<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
    }

    public class NoteInternalDTO
    {
        public int NoteId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class UserInternalDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
