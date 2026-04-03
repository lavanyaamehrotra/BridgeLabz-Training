using System;
public class Truck : Vehicle{
  public Truck(string name, string number, double rent): base(name, number, rent) { }
  public override void DisplayInfo(){
    Console.WriteLine("\n--- Truck Details ---");
    base.DisplayInfo();
  }
  public override double CalculateRent(int days){
    double rent = (baseRentPerDay * days);
    rent += rent * 0.10;
    return rent;
  }
}
