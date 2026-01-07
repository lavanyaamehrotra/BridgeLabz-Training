using System;
public abstract class BankAccount{
    protected double balance;
    protected BankAccount(double balance){
        this.balance = balance;
    }
    // Abstract method to calculate interest
    public abstract double CalculateInterest();
}
