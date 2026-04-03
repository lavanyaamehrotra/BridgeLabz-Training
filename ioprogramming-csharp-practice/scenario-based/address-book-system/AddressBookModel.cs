using System;
// encapsulation
public class AddressBookModel
{
    [Display("First Name")]
    [Required]
    public string FirstName { get; set; }

    [Display("Last Name")]
    [Required]
    public string LastName { get; set; }

    [Display("Address")]
    public string Address { get; set; }

    [Display("City")]
    public string City { get; set; }

    [Display("State")]
    public string State { get; set; }

    [Display("Zip")]
    public string Zip { get; set; }

    [Display("Phone Number")]
    public string PhoneNumber { get; set; }

    [Display("Email")]
    public string Email { get; set; }

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