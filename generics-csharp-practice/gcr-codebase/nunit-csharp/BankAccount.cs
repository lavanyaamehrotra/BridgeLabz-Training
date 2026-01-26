using System;
using NUnit.Framework;
public class BankAccount{
    private double balance;
    // Adds money to the account
    public void Deposit(double amount){
        balance += amount;
    }
    // Withdraws money 
    public void Withdraw(double amount){
        if(amount > balance){
            throw new InvalidOperationException("Insufficient funds");
        }
        balance -= amount;
    }
    // Returns current balance
    public double GetBalance(){
        return balance;
    }
}
[TestFixture]
public class BankAccountTests{
    BankAccount account;
    [SetUp]
    public void Setup(){
        account = new BankAccount();
    }
    [Test]
    public void Deposit_UpdatesBalanceCorrectly(){
        account.Deposit(1000);
        Assert.AreEqual(1000, account.GetBalance());
    }
    [Test]
    public void Withdraw_UpdatesBalanceCorrectly(){
        account.Deposit(1000);
        account.Withdraw(400);
        Assert.AreEqual(600, account.GetBalance());
    }
    [Test]
    public void Withdraw_InsufficientFunds_ThrowsException(){
        account.Deposit(200);
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(500));
    }
}
