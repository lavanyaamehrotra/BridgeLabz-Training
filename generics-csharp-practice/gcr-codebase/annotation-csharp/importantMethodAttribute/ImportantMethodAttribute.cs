using System;
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH"){
        Level = level;
    }
}
