using System;
// Utility class implementing interface
public class AddressBookUtility : IAddressBook{
    // UC-2
    private AddressBookModel[] contacts = new AddressBookModel[100];
    private int count = 0;
    private AddressBookModel model;   // UC-0 welcome message model
    // Constructor
    public AddressBookUtility(){
        model = new AddressBookModel();
        model.WelcomeMessage = "Welcome to Address Book Program";
    }
    // Implementing interface method
    public void DisplayWelcomeMessage(){
        Console.WriteLine(model.WelcomeMessage);
    }
    // UC-1+Uc-2 : Add contacts + Add multiple contacts using AddressBookModel array
    public void AddContact(){
    if (count >= contacts.Length){
        Console.WriteLine("Address Book is Full!");
        return;
    }
    AddressBookModel person = new AddressBookModel();
    Console.Write("Enter First Name : ");
    person.FirstName = Console.ReadLine();
    Console.Write("Enter Last Name  : ");
    person.LastName = Console.ReadLine();
    Console.Write("Enter Address    : ");
    person.Address = Console.ReadLine();
    Console.Write("Enter City       : ");
    person.City = Console.ReadLine();
    Console.Write("Enter State      : ");
    person.State = Console.ReadLine();
    Console.Write("Enter Zip        : ");
    person.Zip = Console.ReadLine();
    Console.Write("Enter Phone No   : ");
    person.PhoneNumber = Console.ReadLine();
    Console.Write("Enter Email      : ");
    person.Email = Console.ReadLine();
    contacts[count] = person;
    count++;
    Console.WriteLine("\nContact Added Successfully!");
    }
}
