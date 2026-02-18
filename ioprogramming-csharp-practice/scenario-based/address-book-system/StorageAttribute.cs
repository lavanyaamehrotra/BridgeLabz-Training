using System;

// Custom Annotation (Attribute)
[AttributeUsage(AttributeTargets.Method)]
public class StorageAttribute : Attribute
{
    public string StorageType { get; }

    public StorageAttribute(string storageType)
    {
        StorageType = storageType;
    }
}
