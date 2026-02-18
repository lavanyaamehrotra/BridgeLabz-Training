using System;
// encapsulation
public class AddressBookModel{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    // UC-0 Welcome Message variable
    public string WelcomeMessage;
    // Used to check duplicate contacts (UC-2)
    public override bool Equals(object? obj){
    AddressBookModel? other = obj as AddressBookModel;

    if (other == null)
        return false;

    return FirstName.Equals(other.FirstName,
            StringComparison.OrdinalIgnoreCase)
        && LastName.Equals(other.LastName,
            StringComparison.OrdinalIgnoreCase);
}
    public override int GetHashCode()
    {
        return (FirstName + LastName)
            .ToLower()
            .GetHashCode();
    }


    public override string ToString(){
        return FirstName + " " + LastName + ", " + City + ", " + State + ", " + PhoneNumber;
    }
}