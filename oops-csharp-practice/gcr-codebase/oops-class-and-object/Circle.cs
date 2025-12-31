using System;
class Circle{
  private double radius;
  // Constructor
  public Circle(double radius){
    this.radius = radius;
  }
  // Method to calculate area
  public double GetArea(){
    return Math.PI * radius * radius;
  }
  // Method to calculate circumference
  public double GetCircumference(){
    return 2 * Math.PI * radius;
  }
  // Method to display details
  public void DisplayDetails(){
    Console.WriteLine("Circle Details:");
    Console.WriteLine("Radius: " + radius);
    Console.WriteLine("Area: " + GetArea());
    Console.WriteLine("Circumference: " + GetCircumference());
  }
   // Main method
  static void Main(string[] args){
    // Create Circle object
    Circle circle = new Circle(5.5);
    // Display results
    circle.DisplayDetails();
  }
}
