using System;
public class Customer{
  public string CustomerName { get; set; }
  public Customer(string name){
    CustomerName = name;
  }
  public void RentVehicle(Vehicle vehicle, int days){
    Console.WriteLine($"\nCustomer: {CustomerName}");
    vehicle.DisplayInfo();
    double totalRent = vehicle.CalculateRent(days);
    Console.WriteLine($"Days Rented: {days}");
    Console.WriteLine($"Total Rent = {totalRent}\n");
  }
}
