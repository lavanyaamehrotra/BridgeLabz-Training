using System;
class Vehicle{
  // Instance Variables
  public string ownerName;
  public string vehicleType;

  // Class Variable
  public static double registrationFee = 2000;
  // Constructor
  public Vehicle(string ownerName, string vehicleType){
    this.ownerName = ownerName;
    this.vehicleType = vehicleType;
  }
  // Instance Method
  public void DisplayVehicleDetails(){
    Console.WriteLine("Owner Name: " + ownerName);
    Console.WriteLine("Vehicle Type: " + vehicleType);
    Console.WriteLine("Registration Fee: " + registrationFee);
  }
  // Class Method
  public static void UpdateRegistrationFee(double newFee){
    registrationFee = newFee;
    Console.WriteLine("Registration fee updated");
  }
}
class Program{
  static void Main(string[] args){
    Vehicle v1 = new Vehicle("Lavanyaa Mehrotra", "Car");
    Vehicle v2 = new Vehicle("Khushi Tiwari", "CAR");
    v1.DisplayVehicleDetails();
    Console.WriteLine();
    v2.DisplayVehicleDetails();
    Console.WriteLine("\nUpdating Registration Fee\n");
    Vehicle.UpdateRegistrationFee(6500);
    Console.WriteLine();
    v1.DisplayVehicleDetails();
    Console.WriteLine();
    v2.DisplayVehicleDetails();
  }
}
