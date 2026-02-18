using System;
using System.Threading.Tasks;   
class AddressBookMain
{
    static async Task Main(string[] args)
    {
        AddressBookUtility utility = new AddressBookUtility();
        utility.DisplayWelcomeMessage();

        int choice;

        do
        {
            Console.WriteLine("\n---- MENU ----");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Add Contact");
            Console.WriteLine("4. Add Multiple Contacts");
            Console.WriteLine("5. Edit Contact");
            Console.WriteLine("6. Delete Contact");
            Console.WriteLine("17. Write Contacts to File");
            Console.WriteLine("18. Read Contacts from File");
            Console.WriteLine("19. Write Contacts to CSV");
            Console.WriteLine("20. Read Contacts from CSV");
            Console.WriteLine("21. Write Contacts to JSON");
            Console.WriteLine("22. Read Contacts from JSON");
            Console.WriteLine("23. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddressBookUtility.CreateAddressBook();
                    break;

                case 2:
                    utility = AddressBookUtility.SelectAddressBook();
                    break;

                case 3:
                    utility.AddContact();
                    break;

                case 4:
                    utility.AddMultipleContacts();
                    break;

                case 5:
                    utility.EditContact();
                    break;

                case 6:
                    utility.DeleteContact();
                    break;

                // ✅ ASYNC CALLS
                case 17:
                    await utility.WriteContactsToFileAsync();
                    break;

                case 18:
                    await utility.ReadContactsFromFileAsync();
                    break;

                case 19:
                    await utility.WriteContactsToCsvFileAsync();
                    break;

                case 20:
                    await utility.ReadContactsFromCsvFileAsync();
                    break;

                case 21:
                    await utility.WriteContactsToJsonFileAsync();
                    break;

                case 22:
                    await utility.ReadContactsFromJsonFileAsync();
                    break;

                case 23:
                    Console.WriteLine("Exiting Program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 23);
    }
}
