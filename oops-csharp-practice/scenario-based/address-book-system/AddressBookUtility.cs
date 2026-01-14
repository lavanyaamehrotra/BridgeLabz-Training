using System;
// Utility class implementing interface
public class AddressBookUtility : IAddressBook{
    // Object of model class
    private AddressBookModel model;
    // Constructor
    public AddressBookUtility(){
        model = new AddressBookModel();
        model.WelcomeMessage = "Welcome to Address Book Program";
    }
    // Implementing interface method
    public void DisplayWelcomeMessage(){
        Console.WriteLine(model.WelcomeMessage);
    }
     // UC-1 ADD CONTACTS IN ADDRESS BOOK
    public void AddContact(){
        Console.Write("Enter First Name : ");
        contact.FirstName = Console.ReadLine();
        Console.Write("Enter Last Name  : ");
        contact.LastName = Console.ReadLine();
        Console.Write("Enter Address    : ");
        contact.Address = Console.ReadLine();
        Console.Write("Enter City       : ");
        contact.City = Console.ReadLine();
        Console.Write("Enter State      : ");
        contact.State = Console.ReadLine();
        Console.Write("Enter Zip        : ");
        contact.Zip = Console.ReadLine();
        Console.Write("Enter Phone No   : ");
        contact.PhoneNumber = Console.ReadLine();
        Console.Write("Enter Email      : ");
        contact.Email = Console.ReadLine();
        Console.WriteLine("\nContact Added Successfully!");
    }
}
