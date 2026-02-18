using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Reflection;


// Utility class implementing interface
public class AddressBookUtility : IAddressBook
{
    // UC-2 : List instead of array
    private List<AddressBookModel> contacts = new List<AddressBookModel>();

    private AddressBookModel model;

    // UC-13 : File path
    private static string textFilePath = "AddressBook.txt";
    //UC-14
    private static string csvFilePath = "AddressBook.csv";
    //UC-15
    private static string jsonFilePath = "AddressBook.json";


    // UC-6 : Multiple Address Books
    private static List<AddressBookUtility> addressBooks = new List<AddressBookUtility>();
    private static List<string> addressBookNames = new List<string>();


    // Constructor
    public AddressBookUtility()
    {
        model = new AddressBookModel();
        model.WelcomeMessage = "Welcome to Address Book Program";
    }


    // UC-0
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine(model.WelcomeMessage);
    }


    // UC-1 + UC-2 : Add Contact
    public void AddContact()
{
    try
    {
        AddressBookModel person =
            CreateContactUsingReflection();

        if (person == null)
            return;

        foreach (var contact in contacts)
        {
            if (contact.Equals(person))
                throw new DuplicateContactException(
                    "Duplicate contact found! Person already exists.");
        }

        contacts.Add(person);

        Console.WriteLine("Contact Added Successfully!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


    // UC-3 : Edit Contact
    public void EditContact()
    {
        try
        {
            Console.Write("Enter First Name to Edit: ");

            string name = Console.ReadLine();

            foreach (var contact in contacts)
            {
                if (contact.FirstName.Equals(name,
                    StringComparison.OrdinalIgnoreCase))
                {

                    Console.Write("New Address : ");
                    contact.Address = Console.ReadLine();

                    Console.Write("New Phone   : ");
                    contact.PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Contact Updated!");

                    return;
                }
            }

            throw new ContactNotFoundException(
                "Contact not found for editing."
            );
        }
        catch (ContactNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    // UC-4 : Delete Contact
    public void DeleteContact()
    {
        try
        {
            Console.Write("Enter First Name to Delete: ");

            string name = Console.ReadLine();

            foreach (var contact in contacts)
            {
                if (contact.FirstName.Equals(name,
                    StringComparison.OrdinalIgnoreCase))
                {
                    contacts.Remove(contact);

                    Console.WriteLine("Contact Deleted!");

                    return;
                }
            }

            throw new ContactNotFoundException(
                "Contact not found for deletion."
            );
        }
        catch (ContactNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    // UC-5
    public void AddMultipleContacts()
    {
        char choice;

        do
        {
            AddContact();

            Console.Write("Add another contact? (y/n): ");

            choice = Console.ReadLine().ToLower()[0];

        } while (choice == 'y');
    }



    // UC-6 Create
    public static void CreateAddressBook()
    {
        Console.Write("Enter Address Book Name: ");

        string name = Console.ReadLine();

        if (addressBookNames.Contains(name))
        {
            Console.WriteLine("Address Book already exists!");

            return;
        }

        addressBooks.Add(new AddressBookUtility());

        addressBookNames.Add(name);

        Console.WriteLine("Address Book Created!");
    }



    // UC-6 Select
    public static AddressBookUtility SelectAddressBook()
    {
        Console.Write("Enter Address Book Name: ");

        string name = Console.ReadLine();

        for (int i = 0; i < addressBookNames.Count; i++)
        {
            if (addressBookNames[i].Equals(name,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book Selected!");

                return addressBooks[i];
            }
        }

        Console.WriteLine("Address Book Not Found!");

        return new AddressBookUtility();
    }



    // UC-7 Search City
    public void SearchPersonByCity()
    {
        Console.Write("Enter City: ");

        string city = Console.ReadLine();

        var result =
            contacts.Where(c => c.City.Equals(city,
            StringComparison.OrdinalIgnoreCase)).ToList();


        if (result.Count == 0)
        {
            Console.WriteLine("No persons found.");

            return;
        }

        DisplayContacts(result);
    }



    // UC-8 Search State
    public void SearchPersonByState()
    {
        Console.Write("Enter State: ");

        string state = Console.ReadLine();

        var result =
            contacts.Where(c => c.State.Equals(state,
            StringComparison.OrdinalIgnoreCase)).ToList();


        if (result.Count == 0)
        {
            Console.WriteLine("No persons found.");

            return;
        }

        DisplayContacts(result);
    }



    // UC-9 View City
    public void ViewPersonByCity()
    {
        SearchPersonByCity();
    }



    // UC-10 View State
    public void ViewPersonByState()
    {
        SearchPersonByState();
    }



    // UC-11 Count City
    public void CountPersonByCity()
    {
        Console.Write("Enter City: ");

        string city = Console.ReadLine();

        int count =
            contacts.Count(c => c.City.Equals(city,
            StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Count: " + count);
    }



    // UC-12 Count State
    public void CountPersonByState()
    {
        Console.Write("Enter State: ");

        string state = Console.ReadLine();

        int count =
            contacts.Count(c => c.State.Equals(state,
            StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Count: " + count);
    }



    // UC-11 Sort Name
    public void SortContactsByName()
    {
        contacts =
            contacts.OrderBy(c => c.FirstName).ToList();

        DisplayContacts();
    }



    public void SortContactsByCity()
    {
        contacts =
            contacts.OrderBy(c => c.City).ToList();

        DisplayContacts();
    }



    public void SortContactsByState()
    {
        contacts =
            contacts.OrderBy(c => c.State).ToList();

        DisplayContacts();
    }



    public void SortContactsByZip()
    {
        contacts =
            contacts.OrderBy(c => c.Zip).ToList();

        DisplayContacts();
    }



    // UC-13 Write File
    public void WriteContactsToFile()
    {
        try
        {
            StreamWriter writer =
                new StreamWriter(textFilePath);

            foreach (var contact in contacts)
            {
                writer.WriteLine(

                    contact.FirstName + "," +
                    contact.LastName + "," +
                    contact.Address + "," +
                    contact.City + "," +
                    contact.State + "," +
                    contact.Zip + "," +
                    contact.PhoneNumber + "," +
                    contact.Email
                );
            }

            writer.Close();

            Console.WriteLine(
                "Contacts written successfully!"
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }



    // UC-13 Read File
    public void ReadContactsFromFile()
    {
        try
        {
            if (!File.Exists(textFilePath))
            {
                Console.WriteLine("File not found");

                return;
            }

            string[] lines =
                File.ReadAllLines(textFilePath);

            contacts.Clear();

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                AddressBookModel person =
                    new AddressBookModel();

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

            Console.WriteLine(
                "Contacts read successfully!"
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    //UC14
        public void WriteContactsToCsvFile(){
        try
        {
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }

            Console.WriteLine("Contacts written to CSV successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void ReadContactsFromCsvFile()
    {
        try
        {
            if (!File.Exists(csvFilePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                contacts = csv.GetRecords<AddressBookModel>().ToList();
            }

            Console.WriteLine("Contacts read from CSV successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
        //UC-15
        public void WriteContactsToJsonFile(){
        try
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true   // pretty JSON
            };

            string jsonData =
                JsonSerializer.Serialize(contacts, options);

            File.WriteAllText(jsonFilePath, jsonData);

            Console.WriteLine("Contacts written to JSON successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
        public void ReadContactsFromJsonFile(){
            try
            {
                if (!File.Exists(jsonFilePath))
                {
                    Console.WriteLine("JSON file not found.");
                    return;
                }

                string jsonData = File.ReadAllText(jsonFilePath);

                contacts =
                    JsonSerializer.Deserialize<List<AddressBookModel>>(jsonData);

                Console.WriteLine("Contacts read from JSON successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // UC-17 : Non-blocking JSON Write
public async Task WriteContactsToJsonFileAsync()
{
    try
    {
        Console.WriteLine("Writing JSON asynchronously...");

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string jsonData =
            JsonSerializer.Serialize(contacts, options);

        await File.WriteAllTextAsync(jsonFilePath, jsonData);

        Console.WriteLine("JSON written successfully (Async)!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
// UC-17 : Non-blocking JSON Read
public async Task ReadContactsFromJsonFileAsync()
{
    try
    {
        Console.WriteLine("Reading JSON asynchronously...");

        if (!File.Exists(jsonFilePath))
        {
            Console.WriteLine("JSON file not found.");
            return;
        }

        string jsonData =
            await File.ReadAllTextAsync(jsonFilePath);

        var data =
            JsonSerializer.Deserialize<List<AddressBookModel>>(jsonData);

        if (data != null)
            contacts = data;

        Console.WriteLine("JSON read successfully (Async)!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
private AddressBookModel CreateContactUsingReflection()
{
    AddressBookModel person = new AddressBookModel();

    var properties =
        typeof(AddressBookModel).GetProperties();

    foreach (var prop in properties)
    {
        var display =
            prop.GetCustomAttribute<DisplayAttribute>();

        if (display == null)
            continue;

        Console.Write($"Enter {display.Label}: ");
        string input = Console.ReadLine();

        var required =
            prop.GetCustomAttribute<RequiredAttribute>();

        if (required != null && string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine($"{display.Label} is required!");
            return null;
        }

        prop.SetValue(person, input);
    }

    return person;
}
private void DisplayContacts()
{
    foreach (var contact in contacts)
    {
        DisplayContact(contact);
    }
}

private void DisplayContacts(List<AddressBookModel> list)
{
    foreach (var contact in list)
    {
        DisplayContact(contact);
    }
}

    private void DisplayContact(AddressBookModel contact)
{
    var properties = typeof(AddressBookModel).GetProperties();

    Console.WriteLine("\n----- Contact -----");

    foreach (var prop in properties)
    {
        var display = prop.GetCustomAttribute<DisplayAttribute>();

        if (display == null)
            continue;

        Console.WriteLine(
            $"{display.Label}: {prop.GetValue(contact)}");
    }

    Console.WriteLine("-------------------");
}
        // ===== TEST SUPPORT METHODS =====

        public void TestAddContact(AddressBookModel person)
        {
            contacts.Add(person);
        }

        public int GetContactCount()
        {
            return contacts.Count;
        }
        public void TestDeleteContact(string name)
        {
            contacts.RemoveAll(c => c.FirstName == name);
        }
}