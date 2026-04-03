using System;
[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute{
    public string Name { get; set; }
}
