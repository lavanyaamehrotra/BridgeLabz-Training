using System;
    public class Menu {
        public void ShowMenu(){
        AadharManager manager = new AadharManager();
        while(true){
            Console.WriteLine("\n--- AADHAR SORTING SYSTEM ---");
            Console.WriteLine("1. Display Aadhar Numbers");
            Console.WriteLine("2. Sort Aadhar Numbers (Radix Sort)");
            Console.WriteLine("3. Search Aadhar Number (Binary Search)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine()!);
            switch(choice){
                case 1:
                    manager.Display();
                    break;
                case 2:
                    manager.SortAadhar();
                    break;
                case 3:
                    Console.Write("Enter Aadhar to search: ");
                    long key = long.Parse(Console.ReadLine()!);
                    manager.SearchAadhar(key);
                    break;
                case 4:
                    Console.WriteLine("Exiting System...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}

