public class AppSender : INotificationSender
{
    public async Task SendAsync(Notification n)
    {
        await Task.Delay(200);
        Console.WriteLine($"App alert sent to {n.Recipient}");
    }
}
