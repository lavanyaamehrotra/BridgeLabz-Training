using System;

public class Service
{
    // STATIC CLASS VARIABLES
    protected static string cityName = "TechVille";   
    protected static int totalServices = 0;

    // INSTANCE VARIABLES
    protected string serviceName;
    protected int serviceID;
    protected int usageCount;

    // Constructor using THIS keyword
    public Service(string serviceName, int serviceID)
    {
        this.serviceName = serviceName;
        this.serviceID = serviceID;
        this.usageCount = 0;

        totalServices++;
    }

    // Virtual method
    public virtual void ProvideService()
    {
        usageCount++;
        Console.WriteLine($"Providing {serviceName} service in {cityName}");
    }

    public void ShowServiceInfo()
    {
        Console.WriteLine($"Service: {serviceName}");
        Console.WriteLine($"Service ID: {serviceID}");
        Console.WriteLine($"Usage Count: {usageCount}");
    }

    // Static method
    public static void ShowTotalServices()
    {
        Console.WriteLine($"Total Services Created: {totalServices}");
    }
}
