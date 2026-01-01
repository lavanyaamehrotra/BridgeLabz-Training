using System;
class Vehicle{
  public static double RegistrationFee = 11000.0;

    // Static method to update fee
    public static void UpdateRegestrationFees(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine($"\nRegistration fee updated {RegistrationFee}\n");
    }
    // Readonly variable
    public readonly string RegistrationNumber;
    // Instance variables
    public string OwnerName;
    public string VehicleType;
    public Vehicle(string registrationNumber, string ownerName, string vehicleType){
      this.RegistrationNumber = registrationNumber;
      this.OwnerName = ownerName;
      this.VehicleType = vehicleType;
    }
    public void DisplayDetails(){
      Console.WriteLine("Vehicle Registration Details:");
      Console.WriteLine($"Registration Number: {RegistrationNumber}");
      Console.WriteLine($"Owner Name : {OwnerName}");
      Console.WriteLine($"Vehicle Type: {VehicleType}");
      Console.WriteLine($"Registration Fee: {RegistrationFee}\n");
    }
}
class RTOSystem{
  static void Main(){
    Vehicle.UpdateRegestrationFees(2000);
    object v1 = new Vehicle("UP701234", "Lavanya Mehrotra", "Car");
    object v2 = new Vehicle("UP651234", "Khushi Tiwari", "Scooty");
    if (v1 is Vehicle){
      ((Vehicle)v1).DisplayDetails();
    }
    if (v2 is Vehicle){
      ((Vehicle)v2).DisplayDetails();
    }
    Console.ReadLine();
  }
}
