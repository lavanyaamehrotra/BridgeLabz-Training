using System.Reflection;
using System.Text.RegularExpressions;
public static class NotificationValidator
{
    public static void Validate(Notification notification)
    {
        foreach (var prop in notification.GetType().GetProperties())
        {
            var value = prop.GetValue(notification);
            if (Attribute.IsDefined(prop, typeof(RequiredAttribute)))
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                    throw new Exception($"{prop.Name} is required");
            }
            var format = prop.GetCustomAttribute<RecipientFormatAttribute>();
            if (format != null && value != null)
            {
                if (!Regex.IsMatch(value.ToString(), format.Pattern))
                    throw new Exception("Invalid recipient format");
            }
        }
    }
}
