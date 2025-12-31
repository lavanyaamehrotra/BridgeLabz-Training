using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops.banking_system{
  internal class BankManager{
    BankAccount account;
    public BankManager(BankAccount acc){
      account = acc;
    }
    public void ManagerMenu(){
      int choice;
      do{
        Console.WriteLine("\n===== BANK MANAGER MENU =====");
        Console.WriteLine("1. View Full Account Details");
        Console.WriteLine("2. Reset Account Balance");
        Console.WriteLine("3. Exit Manager Panel");
        Console.Write("Enter choice: ");
        choice=Convert.ToInt32(Console.ReadLine());
        switch (choice){
          case 1:
          account.ShowAccountDetails();
          break;
          case 2:
          Console.Write("Enter new balance: ");
          double newBal = Convert.ToDouble(Console.ReadLine());
          account.Balance = newBal;
          Console.WriteLine("Balance reset successfully.");
          break;
          case 3:
          Console.WriteLine("Exiting Manager panel...");
          break;
          default:
          Console.WriteLine("Invalid choice.");
          break;
          }
        } while (choice != 3);
      }
    }
}