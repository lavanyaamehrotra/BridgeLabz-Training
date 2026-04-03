using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AddressBookUtilityTests
{
    [TestMethod]
    public void AddContact_ShouldIncreaseContactCount()
    {
        // Arrange
        AddressBookUtility utility = new AddressBookUtility();

        AddressBookModel person = new AddressBookModel
        {
            FirstName = "Rahul",
            LastName = "Sharma",
            City = "Delhi"
        };

        // Act
        utility.TestAddContact(person);

        // Assert
        Assert.AreEqual(1, utility.GetContactCount());
    }
    [TestMethod]
public void DeleteContact_ShouldReduceCount()
{
    AddressBookUtility utility = new AddressBookUtility();

    var person = new AddressBookModel
    {
        FirstName = "Amit",
        LastName = "Kumar"
    };

    utility.TestAddContact(person);

    utility.TestDeleteContact("Amit");

    Assert.AreEqual(0, utility.GetContactCount());
}

}
