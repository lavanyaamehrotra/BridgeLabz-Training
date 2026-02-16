using System;

public class Service
{
    // Class variable (shared)
    protected static string cityName = "TechVille";

    // Instance variables
    protected string serviceName;
    protected int serviceID;

    // Constructor
    public Service(string name, int id)
    {
        serviceName = name;
        serviceID = id;
    }

    // Virtual method
    public virtual void ProvideService()
    {
        Console.WriteLine($"Providing {serviceName} service in {cityName}");
    }

    public void ShowServiceInfo()
    {
        Console.WriteLine($"Service: {serviceName}");
        Console.WriteLine($"Service ID: {serviceID}");
    }
}
