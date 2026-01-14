using System;
class AddressBookMain{
    static void Main(string[] args){
        AddressBookUtility utility = new AddressBookUtility();
        utility.DisplayWelcomeMessage();
        int choice = 0;
        do{
            Console.WriteLine("\n---- MENU ----");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    utility.AddContact();// UC-1+UC-2
                    break;
                case 2:
                    utility.EditContact();// UC-3
                    break;
                case 3:
                    utility.DeleteContact();// UC-4
                    break;
                case 4:
                    Console.WriteLine("Exiting Program.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Try Again.");
                    break;
            }

        } while (choice != 4);
        Console.ReadLine();
    }
}
