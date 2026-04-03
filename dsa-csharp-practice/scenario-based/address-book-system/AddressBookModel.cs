using System;
// encapsulation
public class AddressBookModel{
    public string FirstName;
    public string LastName;
    public string Address;
    public string City;
    public string State;
    public string Zip;
    public string PhoneNumber;
    public string Email;
    // UC-0 Welcome Message variable
    public string WelcomeMessage;
    // Used to check duplicate contacts (UC-2)
    public override bool Equals(object obj){
        AddressBookModel other = obj as AddressBookModel;
        if (other == null){
            return false;
        }
        return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) &&
               LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
    }
    public override string ToString(){
        return FirstName + " " + LastName + ", " + City + ", " + State + ", " + PhoneNumber;
    }
}
