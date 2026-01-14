using System;
class AddressBookMain{
    static void Main(string[] args){
        AddressBookUtility utility = new AddressBookUtility();
        utility.DisplayWelcomeMessage();
        int choice = 0;
        do{
            Console.WriteLine("\n---- MENU ----");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    utility.AddContact();
                    break;
                case 2:
                    Console.WriteLine("Exiting Program.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;
            }

        } while (choice != 2);
        Console.ReadLine();
    }
}
