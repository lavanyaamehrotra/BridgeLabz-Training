using NUnit.Framework;
public class DatabaseConnection{
    public bool IsConnected { get; private set; }
    public void Connect(){
        IsConnected = true;
    }
    public void Disconnect(){
        IsConnected = false;
    }
}
[TestFixture]
public class DatabaseConnectionTests{
    DatabaseConnection db;
    // Runs before each test
    [SetUp]
    public void Setup(){
        db = new DatabaseConnection();
        db.Connect();
    }
    // Runs after each test
    [TearDown]
    public void TearDown(){
        db.Disconnect();
    }
    [Test]
    public void Connect_Test(){
        Assert.IsTrue(db.IsConnected);
    }
    [Test]
    public void Disconnect_Test(){
        db.Disconnect();
        Assert.IsFalse(db.IsConnected);
    }
}
