using System;
public class Car : Vehicle{
  public Car(string name, string number, double rent): base(name, number, rent) { }
  public override void DisplayInfo(){
    Console.WriteLine("\n--- Car Details ---");
    base.DisplayInfo();
  }
  public override double CalculateRent(int days){
    double rent = (baseRentPerDay * days) + 200;
    return rent;
  }
}
