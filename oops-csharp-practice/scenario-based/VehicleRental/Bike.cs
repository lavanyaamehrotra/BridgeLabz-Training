using System;
public class Bike : Vehicle{
  public Bike(string name, string number, double rent): base(name, number, rent) { }
  // Polymorphism
  public override void DisplayInfo(){
    Console.WriteLine("\n--- Bike Details ---");
    base.DisplayInfo();
  }
  public override double CalculateRent(int days){
    double rent = baseRentPerDay * days;
    if (days > 5){
      rent -= rent * 0.05;
    }
    return rent;
  }
}
