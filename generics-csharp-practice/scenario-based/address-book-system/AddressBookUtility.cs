using System;
using System.Collections.Generic;

// Utility class implementing interface
public class AddressBookUtility : IAddressBook{
    // UC-2 : List instead of array
    private List<AddressBookModel> contacts = new List<AddressBookModel>();
    private AddressBookModel model;
    // UC-13 : File path for Address Book
    private static string filePath = "AddressBook.txt";
    // UC-6 : Multiple Address Books
    private static List<AddressBookUtility> addressBooks = new List<AddressBookUtility>();
    private static List<string> addressBookNames = new List<string>();
    // Constructor
    public AddressBookUtility(){
        model = new AddressBookModel();
        model.WelcomeMessage = "Welcome to Address Book Program";
    }
    // UC-0
    public void DisplayWelcomeMessage(){
        Console.WriteLine(model.WelcomeMessage);
    }
    // UC-1 + UC-2 : Add Contact (CUSTOM EXCEPTION RUNS HERE)
    public void AddContact(){
        try{
            AddressBookModel person = new AddressBookModel();
            Console.Write("Enter First Name : ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name  : ");
            person.LastName = Console.ReadLine();
            // Duplicate check → THROW custom exception
            for (int i = 0; i < contacts.Count; i++){
                if (contacts[i].Equals(person)){
                    throw new DuplicateContactException(
                        "Duplicate contact found! Person already exists."
                    );
                }
            }
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
            contacts.Add(person);
            Console.WriteLine("Contact Added Successfully!");
        }
        catch (DuplicateContactException ex){
            Console.WriteLine(ex.Message);
        }
    }
    // UC-3 : Edit Contact (ContactNotFoundException RUNS)
    public void EditContact(){
        try{
            Console.Write("Enter First Name to Edit: ");
            string name = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++){
                if (contacts[i].FirstName!.Equals(name, StringComparison.OrdinalIgnoreCase)){
                    Console.Write("New Address : ");
                    contacts[i].Address = Console.ReadLine();
                    Console.Write("New Phone   : ");
                    contacts[i].PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Contact Updated!");
                    return;
                }
            }
            // If contact not found
            throw new ContactNotFoundException("Contact not found for editing.");
        }
        catch (ContactNotFoundException ex){
            Console.WriteLine(ex.Message);
        }
    }
    // UC-4 : Delete Contact (ContactNotFoundException RUNS)
    public void DeleteContact(){
        try{
            Console.Write("Enter First Name to Delete: ");
            string name = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i++){
                if (contacts[i].FirstName!.Equals(name, StringComparison.OrdinalIgnoreCase)){
                    contacts.RemoveAt(i);
                    Console.WriteLine("Contact Deleted!");
                    return;
                }
            }
            throw new ContactNotFoundException("Contact not found for deletion.");
        }
        catch (ContactNotFoundException ex){
            Console.WriteLine(ex.Message);
        }
    }
    // UC-5
    public void AddMultipleContacts(){
        char choice;
        do{
            AddContact();
            Console.Write("Add another contact? (y/n): ");
            choice = Console.ReadLine().ToLower()[0];
        } while (choice == 'y');
    }
    // UC-6
    public static void CreateAddressBook(){
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();
        if (addressBookNames.Contains(name)){
            Console.WriteLine("Address Book already exists!");
            return;
        }
        addressBooks.Add(new AddressBookUtility());
        addressBookNames.Add(name);
        Console.WriteLine("Address Book Created!");
    }
    // UC-6
    public static AddressBookUtility SelectAddressBook(){
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();
        for (int i = 0; i < addressBookNames.Count; i++){
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Address Book Selected!");
                return addressBooks[i];
            }
        }
        Console.WriteLine("Address Book Not Found!");
        return null;
    }
    // UC-11
    public void SortContactsByName(){
        for (int i = 0; i < contacts.Count - 1; i++){
            for (int j = i + 1; j < contacts.Count; j++){
                if (string.Compare(contacts[i].FirstName,contacts[j].FirstName,StringComparison.OrdinalIgnoreCase) > 0){
                    AddressBookModel temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted Contacts:");
        for (int i = 0; i < contacts.Count; i++){
            Console.WriteLine(contacts[i]);
        }
    }
    //UC-12
    public void SortContactsByCity(){
        contacts.Sort((a, b) =>string.Compare(a.City, b.City, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Contacts Sorted by City:");
        DisplayContacts();
    }
    //UC-12
    public void SortContactsByState(){
        contacts.Sort((a, b) =>string.Compare(a.State, b.State, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Contacts Sorted by State:");
        DisplayContacts();
    }
    //UC-12
    public void SortContactsByZip(){
        contacts.Sort((a, b) =>string.Compare(a.Zip, b.Zip, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Contacts Sorted by Zip:");
        DisplayContacts();
    }
    //UC-12
    private void DisplayContacts(){
        if (contacts.Count == 0){
            Console.WriteLine("No contacts available.");
            return;
        }
    foreach (var contact in contacts){
        Console.WriteLine(contact);
    }
}
    //UC-13-ABILITY TO READ OR WRITE 
    public void WriteContactsToFile(){
    try{
        StreamWriter writer = new StreamWriter(filePath);
        for (int i = 0; i < contacts.Count; i++){
            writer.WriteLine(
                contacts[i].FirstName + "," +
                contacts[i].LastName + "," +
                contacts[i].Address + "," +
                contacts[i].City + "," +
                contacts[i].State + "," +
                contacts[i].Zip + "," +
                contacts[i].PhoneNumber + "," +
                contacts[i].Email
            );
        }
        writer.Close();
        Console.WriteLine("Contacts written to file successfully!");
        }
        catch (Exception ex){
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
    }
    //UC-13-ABILITY TO READ OR WRITE 
    public void ReadContactsFromFile(){
    try{
        if (!File.Exists(filePath)){
            Console.WriteLine("File not found!");
            return;
        }
        string[] lines = File.ReadAllLines(filePath);
        contacts.Clear();
        for (int i = 0; i < lines.Length; i++){
            string[] data = lines[i].Split(',');
            AddressBookModel person = new AddressBookModel();
            person.FirstName = data[0];
            person.LastName = data[1];
            person.Address = data[2];
            person.City = data[3];
            person.State = data[4];
            person.Zip = data[5];
            person.PhoneNumber = data[6];
            person.Email = data[7];
            contacts.Add(person);
        }
        Console.WriteLine("Contac read from file successfully!");
    }
        catch (Exception ex){
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }
}