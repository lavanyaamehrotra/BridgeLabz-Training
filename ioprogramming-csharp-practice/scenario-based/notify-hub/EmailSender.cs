public class EmailSender : INotificationSender
{
    public async Task SendAsync(Notification n)
    {
        await Task.Delay(500);
        Console.WriteLine($"Email sent to {n.Recipient}");
    }
}
