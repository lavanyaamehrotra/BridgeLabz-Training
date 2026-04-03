[AttributeUsage(AttributeTargets.Property)]
public class RequiredAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Property)]
public class RecipientFormatAttribute : Attribute
{
    public string Pattern { get; }

    public RecipientFormatAttribute(string pattern)
    {
        Pattern = pattern;
    }
}
