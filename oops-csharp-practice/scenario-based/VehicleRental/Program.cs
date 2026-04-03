using System;
public class Program{
  public static void Main(){
    // Create vehicle objects
    Bike bike = new Bike("Yamaha FZ", "BIK-101", 500);
    Car car = new Car("Honda City", "CAR-222", 1500);
    Truck truck = new Truck("Tata Heavy", "TRK-333", 3000);
    Customer customer = new Customer("Rahul Sharma");
    // Customer rents different vehicles
    customer.RentVehicle(bike, 6); 
    customer.RentVehicle(car, 4);    
    customer.RentVehicle(truck, 3);
    Console.WriteLine("\nProgram Finished.");
  }
}
