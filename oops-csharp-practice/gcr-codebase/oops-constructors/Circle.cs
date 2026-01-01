using System;
class Circle{
  // Attribute
  public double Radius;
  // Default constructor
  public Circle() : this(1.0){ 
  // Calls the parameterized constructor with default value
  }
  // Parameterized constructor
  public Circle(double radius){
    Radius = radius;
  }
  // Method to calculate area
  public double Area(){
    return Math.PI * Radius * Radius;
  }
  // Method to calculate circumference
  public double Circumference(){
    return 2 * Math.PI * Radius;
  }
  // Method to display circle info
  public void Display(){
    Console.WriteLine($"Radius: {Radius}");
    Console.WriteLine($"Area: {Area():F2}");
    Console.WriteLine($"Circumference: {Circumference():F2}");
  }
}
class Program{
  static void Main(string[] args){
    // Using default constructor
    Circle circle1 = new Circle();
    Console.WriteLine("Circle1 (Default radius):");
    circle1.Display();
    Console.WriteLine();
    // Using parameterized constructor
    Circle circle2 = new Circle(5.0);
    Console.WriteLine("Circle2 (User-provided radius):");
    circle2.Display();
  }
}
