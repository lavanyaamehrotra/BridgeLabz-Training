using System;
// Utility class implementing interface
public class AddressBookUtility : IAddressBook{
    // UC-2
    private AddressBookModel[] contacts = new AddressBookModel[100];
    private int count = 0;
    private AddressBookModel model;   // UC-0 welcome message model
    //  UC-9 CITY ARRAYS 
    // // Stores unique city names
    private static string[] cityList = new string[50];
    // Stores persons of each city (jagged array)
    private static AddressBookModel[][] cityPersons = new AddressBookModel[50][];
    // Stores count of persons per city
    private static int[] cityCount = new int[50];
    // Total number of unique cities stored
    private static int citySize = 0;
    //  UC-9 STATE ARRA
    // Stores unique state names
    private static string[] stateList = new string[50];
    // Stores persons of each state (jagged array)
    private static AddressBookModel[][] statePersons = new AddressBookModel[50][];
    // Stores count of persons per state
    private static int[] stateCount = new int[50];
    // Total number of unique states stored
    private static int stateSize = 0;
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
    if (IsDuplicate(person)){
    Console.WriteLine("\nDuplicate Entry. person already exists in this Address Book.");
    return;
    }
    contacts[count++] = person;
    // Store person city-wise and state-wise
    AddPersonToCity(person);//UC-9
    AddPersonToState(person);//UC-9
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
  private bool IsDuplicate(AddressBookModel person){
    for (int i = 0; i < count; i++){
        if (contacts[i].Equals(person)){
            return true;
        }
    }
    return false;
  }
    // UC-8 : SEARCH PERSON BY CITY IN ADDRESS BOOK
    public static void SearchPersonByCity(){
    Console.Write("Enter City to Search: ");
    string city = Console.ReadLine();
    bool found = false;
    // Loop through all Address Books
    for (int i = 0; i < bookCount; i++){
        AddressBookUtility book = addressBooks[i];
        // Loop through all contacts of the current Address Book
        for (int j = 0; j < book.count; j++){
            // Compare city with each contact
            if (book.contacts[j].City.Equals(city, StringComparison.OrdinalIgnoreCase)){
                found = true;
                // Display matched person details
                Console.WriteLine("\nFound in AddressBook: " + addressBookNames[i]);
                Console.WriteLine("Name : " + book.contacts[j].FirstName + " " + book.contacts[j].LastName);
                Console.WriteLine("City : " + book.contacts[j].City);
                Console.WriteLine("State: " + book.contacts[j].State);
            }
        }
    }
    if (!found)
        Console.WriteLine("no person found in the city");
    }
    // UC-8 : SEARCH PERSON BY STATE IN ADDRESS BOOK
    public static void SearchPersonByState(){
    Console.Write("Enter State to Search: ");
    string state = Console.ReadLine();
    bool found = false;
    // Loop through all Address Books
    for (int i = 0; i < bookCount; i++){
        AddressBookUtility book = addressBooks[i];
        // Loop through all contacts of the current Address Book
        for (int j = 0; j < book.count; j++){
            // Compare state with each contct
            if (book.contacts[j].State.Equals(state, StringComparison.OrdinalIgnoreCase)){
                found = true;
                // Display matched person details
                Console.WriteLine("\nFound in AddressBook: " + addressBookNames[i]);
                Console.WriteLine("Name : " + book.contacts[j].FirstName + " " + book.contacts[j].LastName);
                Console.WriteLine("City : " + book.contacts[j].City);
                Console.WriteLine("State: " + book.contacts[j].State);
            }
        }
    }
    if (!found)
        Console.WriteLine("no person found in this state");
    }
    // Add person
    private static void AddPersonToCity(AddressBookModel person){
    int index = -1;
    // Search city in existing city list
    for (int i = 0; i < citySize; i++){
        if (cityList[i].Equals(person.City, StringComparison.OrdinalIgnoreCase)){
            index = i;
            break;
        }
    }
    if (index == -1){
        cityList[citySize] = person.City;
        cityPersons[citySize] = new AddressBookModel[50];
        cityCount[citySize] = 0;
        index = citySize++;
    }
    // Add person to that city 
    cityPersons[index][cityCount[index]++] = person;
    }
    // Add person into State-wise 
    private static void AddPersonToState(AddressBookModel person){
    int index = -1;
    // Search state in existing state list
    for (int i = 0; i < stateSize; i++){
        if (stateList[i].Equals(person.State, StringComparison.OrdinalIgnoreCase)){
            index = i;
            break;
        }
    }
    // If state not found, create new state 
    if (index == -1){
        stateList[stateSize] = person.State;
        statePersons[stateSize] = new AddressBookModel[50];
        stateCount[stateSize] = 0;
        index = stateSize++;
    }
    // Add person
    statePersons[index][stateCount[index]++] = person;
    }
    // View all persons by City
    public static void ViewPersonsByCity(){
    Console.Write("Enter City Name: ");
    string city = Console.ReadLine();
    for (int i = 0; i < citySize; i++){
        if (cityList[i].Equals(city, StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine("\nPersons in City: " + city);
            for (int j = 0; j < cityCount[i]; j++)
                Console.WriteLine(cityPersons[i][j].FirstName + " " + cityPersons[i][j].LastName);
            return;
        }
    }
    Console.WriteLine("No persons found in this city.");
}
    // View all persons by State
    public static void ViewPersonsByState(){
    Console.Write("Enter State Name: ");
    string state = Console.ReadLine();
    for (int i = 0; i < stateSize; i++){
        if (stateList[i].Equals(state, StringComparison.OrdinalIgnoreCase)){
            Console.WriteLine("\nPersons in State: " + state);
            for (int j = 0; j < stateCount[i]; j++)
                Console.WriteLine(statePersons[i][j].FirstName + " " + statePersons[i][j].LastName);
            return;
        }
    }
    Console.WriteLine("No persons found in this state.");
    }
    // UC-10 : Count persons by City
public static void CountPersonsByCity()
{
    Console.Write("Enter City Name: ");
    string city = Console.ReadLine();
    int total = 0;

    // Search in cityList array
    for (int i = 0; i < citySize; i++)
    {
        if (cityList[i].Equals(city, StringComparison.OrdinalIgnoreCase))
        {
            total = cityCount[i];
            break;
        }
    }

    Console.WriteLine("Total Persons in City " + city + " : " + total);
}
// UC-10 : Count persons by State
public static void CountPersonsByState()
{
    Console.Write("Enter State Name: ");
    string state = Console.ReadLine();
    int total = 0;

    // Search in stateList array
    for (int i = 0; i < stateSize; i++)
    {
        if (stateList[i].Equals(state, StringComparison.OrdinalIgnoreCase))
        {
            total = stateCount[i];
            break;
        }
    }

    Console.WriteLine("Total Persons in State " + state + " : " + total);
}


}