public interface INotificationSender
{
    Task SendAsync(Notification notification);
}
