class Program
{
    static void Main()
    {
        var queue = new NotificationQueue();
        var intake = new NotificationIntakeService(queue);
        var processor = new NotificationProcessor(queue);
        processor.Start();
        intake.Receive(new Notification
        {
            Id = "1",
            Recipient = "user@test.com",
            Message = "Welcome!",
            Priority = PriorityLevel.High,
            Type = NotificationType.Email
        });
        intake.Receive(new Notification
        {
            Id = "2",
            Recipient = "9876543210",
            Message = "OTP Message",
            Priority = PriorityLevel.Medium,
            Type = NotificationType.SMS
        });
        Console.ReadLine();
    }
}
