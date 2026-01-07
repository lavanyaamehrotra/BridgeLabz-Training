using System;
// Subclass of BankAccount implementing ILoanable
public class SavingsAccount : BankAccount, ILoanable{
    public SavingsAccount(double balance) : base(balance) { }
    public override double CalculateInterest(){
        return balance * 0.04;
    }
    // Method to calculate loan eligibility 
    public double CalculateLoanEligibility(){
        return balance * 5;
    }
}
