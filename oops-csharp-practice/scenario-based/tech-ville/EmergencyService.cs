using System;

public class EmergencyService : Service
{
    public EmergencyService(int id, string name)
        : base(name, id)
    {
    }

    // Override behavior
    public override void RegisterService()
    {
        Console.WriteLine($"Emergency service '{serviceName}' activated immediately!");
    }

    // Override cancellation rule
    public override void CancelService()
    {
        Console.WriteLine("Emergency services cannot be cancelled once dispatched.");
    }
}
