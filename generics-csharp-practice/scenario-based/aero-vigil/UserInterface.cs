using System;
class UserInterface{
    public void start(){
        IFlightUtil util = new FlightUtil();
        int choice;
        do{
            Console.WriteLine("\nAeroVigil Menu");
            Console.WriteLine("1. Enter Flight Details");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1){
                try{
                    Console.WriteLine("\nEnter flight details");
                    string input = Console.ReadLine();
                    string[] data = input.Split(':');
                    string flightNumber = data[0];
                    string flightName = data[1];
                    int passengerCount = int.Parse(data[2]);
                    double fuelLevel = double.Parse(data[3]);
                    util.validateFlightNumber(flightNumber);
                    util.validateFlightName(flightName);
                    util.validatePassengerCount(passengerCount, flightName);
                    double fuel =util.calculateFuelToFillTank(flightName, fuelLevel);
                    Console.WriteLine("Fuel required to fill the tank: " +fuel + " liters");
                }
                catch (InvalidFlightException e){
                    Console.WriteLine(e.Message);
                }
                catch (Exception){
                    Console.WriteLine("Invalid input format");
                }
            }
        }
        while (choice != 2);
    }
}
