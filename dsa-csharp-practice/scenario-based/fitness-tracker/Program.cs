using System;
class Program{
    static void Main(){
        User[] users = null;
        Manager manager = new Manager();
        Sorter sorter = new Sorter();
        while (true){
            Console.WriteLine("\n----- Fitness Tracker Menu -----");
            Console.WriteLine("1. Add Step Data");
            Console.WriteLine("2. Display Rankings");
            Console.WriteLine("3. sort Rankings");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter number of users: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    users = manager.AddUsers(n);
                    break;
                case 2:
                    manager.DisplayUsers(users);
                    break;
                case 3:
                    sorter.BubbleSort(users);
                    manager.DisplayUsers(users);
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Fitness Tracker.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
