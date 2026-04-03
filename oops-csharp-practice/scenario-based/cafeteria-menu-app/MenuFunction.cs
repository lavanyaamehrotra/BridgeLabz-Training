using BridgeLabzTraining.oops.Cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.oops.Cafeteria{
  internal static class MenuFunctions{
    public static void DisplayMenu(){
      Console.WriteLine("\n----------- CAFETERIA MENU ------------");
      //loop to print the menu card
      for (int i = 0; i < MenuData.items.Length; i++){
        Console.WriteLine($"{i}  {MenuData.items[i]}  \t Rs.{MenuData.prices[i]}");
      }
    }
    //Method totak multiple orders
    public static void TakeMultipleOrders(){
      int total = 0;
      Console.WriteLine("\nSelect items (enter -1 to stop)\n");
      //using while condition till the user exits
      while (true){
        Console.Write("Enter item index: ");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index == -1){
          break;
        }
        //if index is correct then loop
        if (index < 0 || index >= MenuData.items.Length){
          Console.WriteLine("Invalid index");
          continue;
        }
        Console.WriteLine($"Added: {MenuData.items[index]} - Rs.{MenuData.prices[index]}");
        //Adding the total 
        total += MenuData.prices[index];
      }
      Console.WriteLine("\n------ BILL ------");
      Console.WriteLine($"Total Amount = Rs.{total}");
    }
  }
}