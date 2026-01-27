using System;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute{
    public string Description { get; }
    public BugReportAttribute(string description){
        Description = description;
    }
}
