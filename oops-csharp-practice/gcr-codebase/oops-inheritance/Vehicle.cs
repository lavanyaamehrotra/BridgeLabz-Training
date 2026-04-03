using System;
// Superclass
class Vehicle{
  public string Model;
  public int MaxSpeed;
  public Vehicle(string model, int maxSpeed){
    Model = model;
    MaxSpeed = maxSpeed;
  }
  public void DisplayDetails(){
    Console.WriteLine("Model: " + Model);
    Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
  }
}

// Interface — Refuelable
interface Refuelable{
  void Refuel();
}

// Subclass 1 — Electric Vehicle
class ElectricVehicle : Vehicle{
  public int BatteryCapacity;
  public ElectricVehicle(string model, int maxSpeed, int batteryCapacity): base(model, maxSpeed){
    BatteryCapacity = batteryCapacity;
  }
  public void Charge(){
    Console.WriteLine("\nVehicle Type: Electric Vehicle");
    DisplayDetails();
    Console.WriteLine("Battery Capacity: " + BatteryCapacity + " kWh");
    Console.WriteLine("Status: Charging vehicle");
  }
}

// Subclass 2 — Petrol Vehicle
class PetrolVehicle : Vehicle, Refuelable{
  public int TankCapacity;
  public PetrolVehicle(string model, int maxSpeed, int tankCapacity): base(model, maxSpeed){
    TankCapacity = tankCapacity;
  }
  public void Refuel(){
    Console.WriteLine("\nVehicle Type: Petrol Vehicle");
    DisplayDetails();
    Console.WriteLine("Fuel Tank Capacity: " + TankCapacity + " Liters");
    Console.WriteLine("Status: Vehicle refueled");
  }
}
// Main Class
class VehicleSystem{
  static void Main(string[] args){
    ElectricVehicle ev = new ElectricVehicle("suv", 220, 75);
    PetrolVehicle pv = new PetrolVehicle("Honda", 180, 45);
    ev.Charge();
    pv.Refuel();
  }
}
