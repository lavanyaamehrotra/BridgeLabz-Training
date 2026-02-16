using System;

public class RoutineService : Service
{
    public RoutineService(int id, string name)
        : base(name, id)
    {
    }

    // Override standard behavior
    public override void RegisterService()
    {
        Console.WriteLine($"Routine service '{serviceName}' scheduled normally.");
    }

    // =========================
    // METHOD OVERLOADING
    // =========================

    // Version 1
    public void BookService(string date)
    {
        Console.WriteLine($"Service booked for date: {date}");
    }

    // Version 2 (overloaded)
    public void BookService(string date, string time)
    {
        Console.WriteLine($"Service booked for {date} at {time}");
    }
}
