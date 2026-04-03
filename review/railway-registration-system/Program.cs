using System;
using System.Collections.Generic;
class Program{         
    static void Main(string[] args){
        List<Passenger> passengers = new List<Passenger>();
        Console.Write("Enter number of passengers: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++){
            Console.WriteLine($"\nEnter details for Passenger {i + 1}");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter pnr: ");
            int pnr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter passenger type [1-Senior,2-Normal]: ");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1 && age >= 60){
                passengers.Add(new SeniorPassenger(name, pnr, age));
            }else{
                passengers.Add(new NormalPassenger(name, pnr, age));
            }
        }
        Console.WriteLine("\n--------------passenger details before sortin---------------");
        foreach (var p in passengers){
            p.Display();
        }
        // Sorting by pnr
        PassengerOperations.SortByPNR(passengers);
        Console.WriteLine("\n---------------passenger details after sorting by pnr----------");
        foreach (var p in passengers){
            p.Display();
        }
        // Searching by Name
        Console.Write("\nEnter passenger name to search: ");
        string searchName = Console.ReadLine();
        Passenger result = PassengerOperations.SearchByName(passengers, searchName);
        if (result != null){
            Console.WriteLine("\nPassenger found:");
            result.Display();
        }else{
            Console.WriteLine("\nPassenger not found");
        }
        Console.WriteLine("Thank you for using our Railway registration system");
    }
}
