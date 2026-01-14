using System;
class Program{
    static void Main(string[] args){
        // UC-0 : Display Welcome to Address Book Program
        Console.WriteLine("------ Address Book Application ------");
        // Create object of utility class
        AddressBookUtility utility = new AddressBookUtility();
        // Display welcome message
        utility.DisplayWelcomeMessage();
        Console.ReadLine();
    }
}
