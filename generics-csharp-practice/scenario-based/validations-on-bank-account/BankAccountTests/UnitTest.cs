using NUnit.Framework;
using System;
[TestFixture]   // Required test attribute for class
public class UnitTest{
    [Test]
    public void Test_Deposit_ValidAmount(){
        // Arrange
        Program account = new Program(1000);
        // Act
        account.Deposit(500);
        // Assert 
        Assert.AreEqual(1500, account.Balance);
    }
    [Test]
    public void Test_Deposit_NegativeAmount(){
        // Arrange
        Program account = new Program(1000);
        // Act & Assert
        Assert.Throws<Exception>(() => account.Deposit(-200));
    }
    [Test]
    public void Test_Withdraw_ValidAmount(){
        // Arrange
        Program account = new Program(1000);
        // Act
        account.Withdraw(300);
        // Assert
        Assert.AreEqual(700, account.Balance);
    }
    [Test]
    public void Test_Withdraw_InsufficientFunds(){
        // Arrange
        Program account = new Program(500);
        // Act & Assert 
        Assert.Throws<Exception>(() => account.Withdraw(800));
    }
}
