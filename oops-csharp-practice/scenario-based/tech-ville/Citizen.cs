using System;

public class Citizen
{
    // Private attributes
    private string name;
    private string email;
    private string address;
    private int age;

    // Constructor
    public Citizen(string name, string email, string address, int age)
    {
        this.name = name;
        this.email = email;
        this.address = address;
        SetAge(age);
    }

    // Get Methods (Public access)
    public string GetName() => name;
    public string GetEmail() => email;
    public string GetAddress() => address;
    public int GetAge() => age;

    // Setter with validation
    public void SetAge(int value)
    {
        if (value > 0)
            age = value;
        else
            Console.WriteLine("Invalid Age");
    }

    // Display
    public void DisplayProfile()
    {
        Console.WriteLine("\n--- Citizen Profile ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Age: {age}");
    }
}
