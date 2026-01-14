// Model class demonstrating encapsulation
public class AddressBookModel{
    // Private variable
    private string welcomeMessage;
    // Public property to access private variable
    public string WelcomeMessage{
        get { return welcomeMessage; }
        set { welcomeMessage = value; }
    }
}
