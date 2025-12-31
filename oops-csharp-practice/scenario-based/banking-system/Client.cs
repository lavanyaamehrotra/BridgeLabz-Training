using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.oops.banking_system
{
    internal class Client
    {
        static void Main(string[] args)
        {
            // Collect account info
            Console.Write("Enter Account Holder Name: ");
            string holder = Console.ReadLine();
            if (holder == null) holder = "";

            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();
            if (accNo == null) accNo = "";

            Console.Write("Enter Bank Name: ");
            string bankName = Console.ReadLine();
            if (bankName == null) bankName = "";

            Console.Write("Enter Branch Name: ");
            string branch = Console.ReadLine();
            if (branch == null) branch = "";

            Console.Write("Enter IFSC Code: ");
            string ifsc = Console.ReadLine();
            if (ifsc == null) ifsc = "";

            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            if (city == null) city = "";

            // Opening balance input
            double balance = 0;
            bool validBalance = false;
            while (!validBalance)
            {
                Console.Write("Enter Opening Balance: ");
                string input = Console.ReadLine();
                try
                {
                    balance = Convert.ToDouble(input);
                    if (balance >= 0)
                        validBalance = true;
                    else
                        Console.WriteLine("Balance cannot be negative.");
                }
                catch
                {
                    Console.WriteLine("Invalid input! Enter a number.");
                }
            }

            // Create account
            BankAccount account = new BankAccount(accNo, holder, balance, bankName, branch, ifsc, city);BankManager manager = new BankManager(account);
            //login panel menu
            int userType = 0;
            do{
                Console.WriteLine("\n=============== LOGIN PANEL=====================");
                Console.WriteLine("1. Bank User");
                Console.WriteLine("2. Bank Manager");
                Console.WriteLine("3. Exit App");
                Console.Write("Select user type: ");

                try{
                    userType = Convert.ToInt32(Console.ReadLine());
                }
                catch{
                    Console.WriteLine("Invalid input! Enter a number.");
                    continue;
                }

                switch (userType){
                    case 1:
                        UserMenu(account);
                        break;
                    case 2:
                        manager.ManagerMenu();
                        break;
                    case 3:
                        Console.WriteLine("Thanku");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

            } while (userType != 3);
        }
        //function for user menu
        static void UserMenu(BankAccount account){
            int choice = 0;
            do{
                Console.WriteLine("\n===== BANK USER MENU =====");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit User Panel");
                Console.Write("Enter choice: ");

                try{
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch{
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice){
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        try{
                            double dep = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(dep);
                        }
                        catch{
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case 2:
                        Console.Write("Enter withdraw amount: ");
                        try{
                            double wd = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(wd);
                        }
                        catch{
                            Console.WriteLine("Invalid amount");
                        }
                        break;

                    case 3:
                        account.CheckBalance();
                        break;

                    case 4:
                        Console.WriteLine("Exiting User Panel...");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
