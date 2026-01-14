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
}
