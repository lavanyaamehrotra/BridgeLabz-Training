using System;
// Marks an API as public
[AttributeUsage(AttributeTargets.Method)]
public class PublicAPIAttribute : Attribute{
    public string Description { get; }
    public PublicAPIAttribute(string description){
        Description = description;
    }
}
// Marks an API that needs authentication
[AttributeUsage(AttributeTargets.Method)]
public class RequiresAuthAttribute : Attribute{}
