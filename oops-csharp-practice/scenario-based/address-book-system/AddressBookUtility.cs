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
    //UC-6 ADD ADDRESS BOOK
    private static AddressBookUtility[] addressBooks = new AddressBookUtility[10];
    private static string[] addressBookNames = new string[10];
    private static int bookCount = 0;
    // Implementing interface method
    public void DisplayWelcomeMessage(){
        Console.WriteLine(model.WelcomeMessage);
    }
    // UC-1 + UC-2 : Add contacts + Add multiple contacts using AddressBookModel array
    public void AddContact(){
    if (count >= contacts.Length){
        Console.WriteLine("Address Book is Full!");
        return;
    }
    AddressBookModel person = new AddressBookModel();
    Console.Write("Enter First Name : ");
    person.FirstName = Console.ReadLine();
    Console.Write("Enter Last Name : ");
    person.LastName = Console.ReadLine();
    Console.Write("Enter Address   : ");
    person.Address = Console.ReadLine();
    Console.Write("Enter City    : ");
    person.City = Console.ReadLine();
    Console.Write("Enter State    : ");
    person.State = Console.ReadLine();
    Console.Write("Enter Zip      : ");
    person.Zip = Console.ReadLine();
    Console.Write("Enter Phone No  : ");
    person.PhoneNumber = Console.ReadLine();
    Console.Write("Enter Email    : ");
    person.Email = Console.ReadLine();
    contacts[count] = person;
    count++;
    Console.WriteLine("\nContact Added Successfully!");
    }
    // UC-3 : Edit existing contact using First Name
    public void EditContact(){
    Console.Write("\nEnter First Name to edit: ");
    string name = Console.ReadLine();
    bool found = false;
    for (int i = 0; i < count; i++){
        if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)){
            found = true;
            Console.WriteLine("\nContact Found");
            Console.Write("Enter New Address  : ");
            contacts[i].Address = Console.ReadLine();
            Console.Write("Enter New City    : ");
            contacts[i].City = Console.ReadLine();
            Console.Write("Enter New State    : ");
            contacts[i].State = Console.ReadLine();
            Console.Write("Enter New Zip      : ");
            contacts[i].Zip = Console.ReadLine();
            Console.Write("Enter New Phone No  : ");
            contacts[i].PhoneNumber = Console.ReadLine();
            Console.Write("Enter New Email    : ");
            contacts[i].Email = Console.ReadLine();
            Console.WriteLine("\nContact Updated Successfully!");
            break;
        }
    }
    if (!found)
        Console.WriteLine("\nContact Not Found!");
    }
    // UC-4 : Delete contact using First Name
    public void DeleteContact(){
    Console.WriteLine("\nEnter First Name of contact to delete: ");
    string name = Console.ReadLine();
    bool found = false;
    for (int i = 0; i < count; i++){
        if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase)){
            found = true;
            // Shifting remaining contacts to left
            for (int j = i; j < count - 1; j++){
                contacts[j] = contacts[j + 1];
            }
            contacts[count - 1] = null;
            count--;
            Console.WriteLine("\nContact deleted successfully");
            break;
        }
    }
    if (!found)
        Console.WriteLine("\nContact not found");
    }
    // UC-5 : Add multiple contacts
    public void AddMultipleContacts(){
    char choice;
    do{
        AddContact();   // reusing UC-1 & UC-2 method
        Console.Write("\nDo you want to add another contact? (yes/no): ");
        choice = Convert.ToChar(Console.ReadLine().ToLower());
        } while (choice == 'y');
    }
     // UC-6 CREATE ADDRESS BOOK
     public static void CreateAddressBook(){
    if (bookCount >= addressBooks.Length){
        Console.WriteLine("Address Book limit reached!");
        return;
    }
    Console.Write("Enter Unique Address Book Name: ");
    string name = Console.ReadLine();
    for (int i = 0; i < bookCount; i++){
        if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase)){
              Console.WriteLine("Address Book Already Exists!");
              return;
          }
      }
      addressBooks[bookCount] = new AddressBookUtility();
      addressBookNames[bookCount++] = name;
      Console.WriteLine("Address Book Created Successfully!");
  }
    public static AddressBookUtility SelectAddressBook(){
      Console.Write("Enter Address Book Name: ");
      string name = Console.ReadLine();
      for (int i = 0; i < bookCount; i++){
          if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase)){
              Console.WriteLine("Address Book Selected!");
              return addressBooks[i];
          }
      }
      Console.WriteLine("Address Book Not Found!");
      return null;
  }
}
