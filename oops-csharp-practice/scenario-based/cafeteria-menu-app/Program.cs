using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops.Cafeteria{
  internal class Program{
    static void Main(){
      //using while condition until true
      while (true){
        MenuFunctions.DisplayMenu();
        Console.WriteLine("\n1. Order Items");
        Console.WriteLine("2. Exit");
        Console.Write("\nEnter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        //if user selects 2 then exit
        if (choice == 2){
          break;
        }
        //if one then select the item to be ordered
        if (choice == 1){
          MenuFunctions.TakeMultipleOrders();
          Console.WriteLine("\nPress any key to continue...");
          Console.ReadKey();
        }
      }
    }
  }
}