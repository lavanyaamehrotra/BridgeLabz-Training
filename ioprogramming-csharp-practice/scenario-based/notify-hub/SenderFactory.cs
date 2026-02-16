public static class SenderFactory
{
    public static INotificationSender GetSender(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new EmailSender(),
            NotificationType.SMS => new SmsSender(),
            NotificationType.App => new AppSender(),
            _ => throw new NotSupportedException()
        };
    }
}
