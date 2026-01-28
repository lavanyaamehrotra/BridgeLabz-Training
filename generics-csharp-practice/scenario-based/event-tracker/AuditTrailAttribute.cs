using System;
// Marks methods that need audit logging
[AttributeUsage(AttributeTargets.Method)]
public class AuditTrailAttribute : Attribute{
    public string ActionName { get; }
    public AuditTrailAttribute(string actionName){
        ActionName = actionName;
    }
}
