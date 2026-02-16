public class NotificationQueue
{
    private readonly PriorityQueue<Notification, int> _queue = new();
    private readonly object _lock = new();
    public void Enqueue(Notification notification)
    {
        lock (_lock)
        {
            _queue.Enqueue(notification, -(int)notification.Priority);
        }
    }
    public bool TryDequeue(out Notification notification)
    {
        lock (_lock)
        {
            return _queue.TryDequeue(out notification, out _);
        }
    }
}
