using System;
public class Program{
    public decimal Balance { get; set; }
    // Constructor
    public Program(decimal initialBalance){
        Balance = initialBalance;
    }
    // Deposit method
    public void Deposit(decimal amount){
        if (amount < 0){
            throw new Exception("Deposit amount cannot be negative");
        }
        Balance += amount;
    }
    // Withdraw method
    public void Withdraw(decimal amount){
        if (amount > Balance){
            throw new Exception("Insufficient funds.");
        }
        Balance -= amount;
    }
}
