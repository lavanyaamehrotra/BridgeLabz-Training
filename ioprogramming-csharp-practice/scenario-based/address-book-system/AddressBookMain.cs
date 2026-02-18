using System;
class AddressBookMain
{
    static void Main(string[] args)
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
            Console.WriteLine("7. Search Person By City");
            Console.WriteLine("8. Search Person By State");
            Console.WriteLine("9. View Person By City");
            Console.WriteLine("10. View Person By State");
            Console.WriteLine("11. Count Person By City");
            Console.WriteLine("12. Count Person By State");
            Console.WriteLine("13. Sort Contacts by Name");
            Console.WriteLine("14. Sort Contacts by City");
            Console.WriteLine("15. Sort Contacts by State");
            Console.WriteLine("16. Sort Contacts by Zip");
            Console.WriteLine("17. Write Contacts to TXT File");
            Console.WriteLine("18. Read Contacts from TXT File");
            Console.WriteLine("19. Write Contacts to CSV File");
            Console.WriteLine("20. Read Contacts from CSV File");
            Console.WriteLine("21. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddressBookUtility.CreateAddressBook();
                    break;

                case 2:
                    AddressBookUtility selected = AddressBookUtility.SelectAddressBook();
                    if (selected != null)
                        utility = selected;
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

                case 7:
                    utility.SearchPersonByCity();
                    break;

                case 8:
                    utility.SearchPersonByState();
                    break;

                case 9:
                    utility.ViewPersonByCity();
                    break;

                case 10:
                    utility.ViewPersonByState();
                    break;

                case 11:
                    utility.CountPersonByCity();
                    break;

                case 12:
                    utility.CountPersonByState();
                    break;

                case 13:
                    utility.SortContactsByName();
                    break;

                case 14:
                    utility.SortContactsByCity();
                    break;

                case 15:
                    utility.SortContactsByState();
                    break;

                case 16:
                    utility.SortContactsByZip();
                    break;

                case 17:
                    utility.WriteContactsToFile();
                    break;

                case 18:
                    utility.ReadContactsFromFile();
                    break;

                case 19:
                    utility.WriteContactsToCsvFile();
                    break;

                case 20:
                    utility.ReadContactsFromCsvFile();
                    break;

                case 21:
                Console.WriteLine("Thank you");
                return;
                
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }while(choice!=21);
    }
}