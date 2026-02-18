using System;

public interface IAddressBook
{
    // UC-0
    void DisplayWelcomeMessage();
    // UC-1 + UC-2
    void AddContact();
    // UC-3
    void EditContact();
    // UC-4
    void DeleteContact();
    // UC-5
    void AddMultipleContacts();
    // UC-7
    void SearchPersonByCity();
    // UC-8
    void SearchPersonByState();
    // UC-9
    void ViewPersonByCity();
    // UC-10
    void ViewPersonByState();
    // UC-11
    void CountPersonByCity();
    // UC-12
    void CountPersonByState();
    // UC-11 Sorting
    void SortContactsByName();
    // UC-12 Sorting
    void SortContactsByCity();
    void SortContactsByState();
    void SortContactsByZip();
    // UC-13 File IO
    void WriteContactsToFile();
    void ReadContactsFromFile();
}