using System;
using System.Collections.Generic;
class UserInterface{
    static void Main(){
        VesselUtil util = new VesselUtil();
        int choice;
        do{
            // Display menu
            Console.WriteLine("\n--- OceanFleet Menu ---");
            Console.WriteLine("1. Add Vessel Details");
            Console.WriteLine("2. Search Vessel by Id");
            Console.WriteLine("3. Display High Performance Vessels");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    // Add vessel details
                    Console.WriteLine("Enter vessel details (vesselId:vesselName:averageSpeed:vesselType)");
                    string input = Console.ReadLine();
                    string[] data = input.Split(':');
                    Vessel vessel = new Vessel(data[0],data[1],double.Parse(data[2]),data[3]);
                    util.AddVesselPerformance(vessel);
                    Console.WriteLine("Vessel added successfully");
                    break;
                case 2:
                    // Search vessel by Id
                    Console.WriteLine("Enter the Vessel Id to check speed");
                    string id = Console.ReadLine();
                    Vessel found = util.GetVesselById(id);
                    if (found != null){
                        Console.WriteLine(found.VesselId + " | " +found.VesselName + " | " +found.VesselType + " | " + found.AverageSpeed + " knots");
                    }
                    else{
                        Console.WriteLine("Vessel Id " + id + " not found");
                    }
                    break;
                case 3:
                    // Display high performance vessels
                    Console.WriteLine("High performance vessels are");
                    List<Vessel> list = util.GetHighPerformanceVessels();
                    // Using for loop instead of foreach
                    for (int i = 0; i < list.Count; i++){
                        Console.WriteLine(list[i].VesselId + " | " +list[i].VesselName + " | " +list[i].VesselType + " | " +list[i].AverageSpeed + " knots");
                    }
                    break;
                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 4);
    }
}
