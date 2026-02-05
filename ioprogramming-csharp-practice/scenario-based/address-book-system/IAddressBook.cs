public interface IAddressBook{
    void DisplayWelcomeMessage(); // UC-0
    void AddContact();            // UC-1 + UC-2
    void EditContact();           // UC-3
    void DeleteContact();         // UC-4
    void AddMultipleContacts();   // UC-5
    void SortContactsByCity();    //UC-12
    void SortContactsByState();   //UC-12
    void SortContactsByZip();    //UC-12

}