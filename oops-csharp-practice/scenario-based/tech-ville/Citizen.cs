using System;

public class Citizen
{
    // Properties
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }

    // Constructor
    public Citizen(string name, string email, string address, int age)
    {
        Name = name;
        Email = email;
        Address = address;
        Age = age;
    }

    // Display Method
    public void DisplayProfile()
    {
        Console.WriteLine("\n--- Citizen Profile ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Age: " + Age);
    }
}
