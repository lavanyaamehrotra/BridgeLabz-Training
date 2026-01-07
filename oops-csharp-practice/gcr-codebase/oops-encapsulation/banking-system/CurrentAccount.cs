using System;
// Subclass of BankAccount
public class CurrentAccount : BankAccount{
    public CurrentAccount(double balance) : base(balance) { }
    // Method to calculate interest
    public override double CalculateInterest(){
        return balance * 0.02;
    }
}
