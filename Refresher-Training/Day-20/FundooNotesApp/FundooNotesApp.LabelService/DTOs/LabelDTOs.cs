namespace FundooNotesApp.LabelService.DTOs
{
    public class CreateLabelDTO
    {
        public string LabelName { get; set; } = string.Empty;
        public int NoteId { get; set; }
    }

    public class EditLabelDTO
    {
        public string LabelName { get; set; } = string.Empty;
    }

    public class ResponseDTO<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
    }
}
