public class NotificationIntakeService
{
    private readonly NotificationQueue _queue;

    public NotificationIntakeService(NotificationQueue queue)
    {
        _queue = queue;
    }

    public void Receive(Notification notification)
    {
        try
        {
            NotificationValidator.Validate(notification);
            _queue.Enqueue(notification);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Rejected: {ex.Message}");
        }
    }
}
