using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

[TestClass]
public class AddressBookUtilityTests
{
    private AddressBookUtility utility;

    [TestInitialize]
    public void Setup()
    {
        utility = new AddressBookUtility();
    }

    [TestMethod]
    public void AddContact_Test()
    {
        utility.AddTestContact("John", "Doe");

        Assert.AreEqual(1, utility.GetContactCount());
    }

    [TestMethod]
    public void DeleteContact_Test()
    {
        utility.AddTestContact("A", "B");
        utility.DeleteTestContact("A");

        Assert.AreEqual(0, utility.GetContactCount());
    }

    [TestMethod]
    public async Task JsonWrite_Test()
    {
        utility.AddTestContact("Test", "User");

        await utility.WriteContactsToJsonFileAsync();

        Assert.IsTrue(System.IO.File.Exists("AddressBook.json"));
    }

    [TestMethod]
    public async Task ReflectionExecution_Test()
    {
        utility.AddTestContact("Ref", "User");

        await utility.ExecuteStorageOperation("JSON", "Write");

        Assert.IsTrue(System.IO.File.Exists("AddressBook.json"));
    }
}
