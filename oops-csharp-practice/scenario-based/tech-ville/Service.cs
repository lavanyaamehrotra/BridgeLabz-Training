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
    // Common service operations
    public virtual void RegisterService()
    {
        Console.WriteLine($"{serviceName} registered.");
    }

    public virtual void CancelService()
    {
        Console.WriteLine($"{serviceName} cancelled.");
    }

    public virtual void CheckStatus()
    {
        Console.WriteLine($"{serviceName} status: Active");
    }
    // =========================
    // Object Class Overrides (Module 8)
    // =========================

    // Equivalent of Java toString()
    public override string ToString()
    {
        return $"Service[{serviceID}] - {serviceName}";
    }

    // Equivalent of equals()
    public override bool Equals(object obj)
    {
        if (obj is Service other)
        {
            return this.serviceID == other.serviceID;
        }
        return false;
    }

    // Equivalent of hashCode()
    public override int GetHashCode()
    {
        return serviceID.GetHashCode();
    }


}
