using System;
public abstract class Vehicle : IRentable{
  protected string vehicleName;
  protected string vehicleNumber;
  protected double baseRentPerDay;
  public string VehicleName{
    get {return vehicleName;}
    set{vehicleName=value;}
  }
  public string VehicleNumber{
    get {return vehicleNumber;}
    set{vehicleNumber=value;}
  }
  public double BaseRentPerDay{
    get {return baseRentPerDay;}
    set{baseRentPerDay=value;}
  }
  protected Vehicle(string name,string number,double rent){
    vehicleName=name;
    vehicleNumber=number;
    baseRentPerDay=rent;

  }
  public virtual void DisplayInfo(){
    Console.WriteLine($"\nVehicle: {vehicleName}");
    Console.WriteLine($"Number: {vehicleNumber}");
    Console.WriteLine($"Base Rent / Day: {baseRentPerDay}");
  }
   public abstract double CalculateRent(int days);
}