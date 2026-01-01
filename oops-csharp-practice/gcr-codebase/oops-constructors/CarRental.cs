using System;
class CarRental{
  public string CustomerName;
  public string CarModel;
  public int RentalDays;
  public double DailyRate;
  public double TotalCost;
  // Default constructor
  public CarRental(){
    CustomerName = "Unknown";
    CarModel = "Standard";
    RentalDays = 1;
    DailyRate = 1000;   // default rate
    TotalCost = RentalDays * DailyRate;
  }
  // Parameterized constructor
  public CarRental(string customerName, string carModel, int rentalDays, double dailyRate){
  CustomerName = customerName;
  CarModel = carModel;
  RentalDays = rentalDays;
  DailyRate = dailyRate;
  TotalCost = RentalDays * DailyRate;
  }
  public void Display(){
    Console.WriteLine($"Customer Name : {CustomerName}");
    Console.WriteLine($"Car Model     : {CarModel}");
    Console.WriteLine($"Rental Days   : {RentalDays}");
    Console.WriteLine($"Daily Rate    : {DailyRate}");
    Console.WriteLine($"Total Cost    : {TotalCost}");
  }
}
class Program{
  static void Main(string[] args){
    // Default rental
    CarRental r1 = new CarRental();
    Console.WriteLine("Default Rental:");
    r1.Display();
    Console.WriteLine();
    // Parameterized rental
    CarRental r2 = new CarRental("John Doe", "Sedan", 5, 1500);
    Console.WriteLine("Custom Rental:");
    r2.Display();
  }
}
