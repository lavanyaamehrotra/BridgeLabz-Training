using System;
[AttributeUsage(AttributeTargets.Class)]
public class RoleAllowedAttribute : Attribute{
    public string Role { get; }
    public RoleAllowedAttribute(string role){
        Role = role;
    }
}
