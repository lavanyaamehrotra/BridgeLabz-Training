public class Notification
{
    [Required]
    public string Id { get; set; }

    [Required]
    [RecipientFormat(@"^\S+@\S+\.\S+$|^\d{10}$")]
    public string Recipient { get; set; }

    public string Message { get; set; }

    public PriorityLevel Priority { get; set; }

    public NotificationType Type { get; set; }

    public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

    public string Status { get; set; } = "Pending";
}
