public class SmsSender : INotificationSender
{
    public async Task SendAsync(Notification n)
    {
        await Task.Delay(300);
        Console.WriteLine($"SMS sent to {n.Recipient}");
    }
}
