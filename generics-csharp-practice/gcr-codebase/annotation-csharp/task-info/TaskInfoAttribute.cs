using System;
[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute{
    public string Priority { get; }
    public string AssignedTo { get; }
    public TaskInfoAttribute(string priority, string assignedTo){
        Priority = priority;
        AssignedTo = assignedTo;
    }
}
