using System;
class BusTracker{
  public static void Main(string[] args){
    int totalDistance = 0;
    int choice;
    Console.WriteLine("Bus Route Distance Tracker Started");
    do{
      Console.WriteLine("\n------ MENU ------");
      Console.WriteLine("1. Add distance at stop");
      Console.WriteLine("2. View total distance travelled");
      Console.WriteLine("3. Exit");
      Console.Write("Enter your choice: ");
      choice = Convert.ToInt32(Console.ReadLine());
      switch (choice){
        case 1:
        Console.Write("Enter distance covered at this stop (in km): ");
        int distance = Convert.ToInt32(Console.ReadLine());
        totalDistance += distance;
        Console.WriteLine("Distance added successfully.");
        break;
        case 2:
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
        break;
        case 3:  
        Console.WriteLine("\nPassenger got off the bus.");
        Console.WriteLine("Final distance travelled: " + totalDistance + " km");
        break;
        default:
        Console.WriteLine("Invalid choice! Please try again.");
        break;
      }
    } while (choice != 3);
  }
}