public class NotificationProcessor
{
    private readonly NotificationQueue _queue;
    private readonly int _workers;

    public NotificationProcessor(NotificationQueue queue, int workers = 3)
    {
        _queue = queue;
        _workers = workers;
    }

    public void Start()
    {
        for (int i = 0; i < _workers; i++)
            Task.Run(ProcessLoop);
    }

    private async Task ProcessLoop()
    {
        while (true)
        {
            if (_queue.TryDequeue(out var notification))
                await Handle(notification);
            else
                await Task.Delay(100);
        }
    }

    private async Task Handle(Notification notification)
    {
        try
        {
            var sender = SenderFactory.GetSender(notification.Type);

            await sender.SendAsync(notification);

            notification.Status = "Sent";
        }
        catch (Exception ex)
        {
            notification.Status = "Failed";
            Console.WriteLine($"Failure: {ex.Message}");
        }
    }
}
