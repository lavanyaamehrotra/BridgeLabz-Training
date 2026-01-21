using System;
    //encapsulation
    public abstract class Passenger{
    public string Name { get; set; }
    public int PNR { get; set; }
    public int Age { get; set; }
    //constructor
    public Passenger(string name, int pnr, int age){
        Name = name;
        PNR = pnr;
        Age = age;
    }
    // Abstract method (polymorphism)
    public abstract double CalculateFare();
    public void Display(){
        Console.WriteLine($"Name: {Name}, PNR: {PNR}, Age: {Age}, Fare: {CalculateFare()}");
    }
}

