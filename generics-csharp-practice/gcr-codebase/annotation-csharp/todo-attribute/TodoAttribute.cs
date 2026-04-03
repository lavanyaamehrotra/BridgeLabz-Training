using System;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; set; } = "MEDIUM";
    public TodoAttribute(string task, string assignedTo){
        Task = task;
        AssignedTo = assignedTo;
    }
}
