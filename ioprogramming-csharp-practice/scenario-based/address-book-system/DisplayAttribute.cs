using System;

[AttributeUsage(AttributeTargets.Property)]
public class DisplayAttribute : Attribute
{
    public string Label { get; }

    public DisplayAttribute(string label)
    {
        Label = label;
    }
}
