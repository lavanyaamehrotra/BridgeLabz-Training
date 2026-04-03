using System;
// Superclass
class Vehicle{
  public int MaxSpeed;
  public string FuelType;
  public Vehicle(int maxSpeed, string fuelType){
    MaxSpeed = maxSpeed;
    FuelType = fuelType;
  }
  public virtual void DisplayInfo(){
    Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
    Console.WriteLine($"Fuel Type: {FuelType}");
  }
}
// Subclass — Car
class Car : Vehicle{
    public int SeatCapacity;
    public Car(int maxSpeed, string fuelType, int seatCapacity): base(maxSpeed, fuelType){
      SeatCapacity = seatCapacity;
    }
    public override void DisplayInfo(){
      Console.WriteLine("\nVehicle Type: Car");
      base.DisplayInfo();
      Console.WriteLine($"Seat Capacity: {SeatCapacity}");
    }
}

// Subclass — Truck
class Truck : Vehicle{
  public int PayloadCapacity;
  public Truck(int maxSpeed, string fuelType, int payloadCapacity): base(maxSpeed, fuelType){
    PayloadCapacity = payloadCapacity;
  }
  public override void DisplayInfo(){
    Console.WriteLine("\nVehicle Type: Truck");
    base.DisplayInfo();
    Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
  }
}

// Subclass — Motorcycle
class Motorcycle : Vehicle{
  public bool HasSidecar;
  public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar): base(maxSpeed, fuelType){
    HasSidecar = hasSidecar;
  }
  public override void DisplayInfo(){
    Console.WriteLine("\nVehicle Type: Motorcycle");
    base.DisplayInfo();
    Console.WriteLine($"Has Sidecar: {HasSidecar}");
  }
}

// Main Class
class TransportSystem{
  static void Main(string[] args){
    Vehicle[] vehicles = new Vehicle[]{
    new Car(180, "Petrol", 5),
    new Truck(120, "Diesel", 8000),
    new Motorcycle(160, "Petrol", false)};
    foreach (Vehicle v in vehicles){
    v.DisplayInfo();
    }
  }
}
