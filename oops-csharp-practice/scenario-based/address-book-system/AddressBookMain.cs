using System;
class AddressBookMain{
    static void Main(string[] args){
        AddressBookUtility utility = new AddressBookUtility();
        utility.DisplayWelcomeMessage();
        int choice = 0;
        do{
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
            Console.WriteLine("13. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    AddressBookUtility.CreateAddressBook();//UC-6
                    break;
                case 2:
                    utility = AddressBookUtility.SelectAddressBook();//UC-6
                    break;
                case 3:
                    utility.AddContact();// UC-1+UC-2
                    break;
                case 4:
                    utility.AddMultipleContacts(); // UC-5
                    break;
                case 5:
                    utility.EditContact();// UC-3
                    break;
                case 6:
                    utility.DeleteContact();// UC-4
                    break;
                case 7:
                    AddressBookUtility.SearchPersonByCity();//UC-8
                    break;
                case 8:
                    AddressBookUtility.SearchPersonByState();//UC-8
                    break;
                case 9:
                    AddressBookUtility.ViewPersonsByCity();//UC-9
                    break;
                case 10:
                    AddressBookUtility.ViewPersonsByState();//UC-9
                    break;
                case 11:
                    AddressBookUtility.CountPersonsByCity();
                    break;
                case 12:
                    AddressBookUtility.CountPersonsByState();
                    break;
                case 13:
                    Console.WriteLine("Exiting Program.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice Try Again.");
                    break;
            }

        } while (choice != 13);
        Console.ReadLine();
    }
}
