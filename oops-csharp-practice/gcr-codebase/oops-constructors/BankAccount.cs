using System;
class BankAccount{
    // attributes of the class
    public int accountNumber;    
    // protected
    protected string accountHolder; 
    // private  
    private double balance;          
    // Constructor 
    public BankAccount(int accNo, string holder, double balance){
        accountNumber = accNo;
        accountHolder = holder;
        this.balance = balance;
    }
    // Access private balance
  public double GetBalance(){
    return balance;
  }
    // Modify private balance
  public void Deposit(double amount){
    balance += amount;
  }
}
// Subclass of BankAccount
class SavingsAccount : BankAccount{
  public SavingsAccount(int accNo, string holder, double balance): base(accNo, holder, balance) { }
    // Method to display account details
    public void Display(){
      Console.WriteLine("\nAccount Number: " + accountNumber);
      Console.WriteLine("Account Holder: " + accountHolder);
      Console.WriteLine("Balance: " + GetBalance());
    }
}
class BankAccountSystem{
  public static void Main(string[] args) {
  // Creating a savings account
  SavingsAccount sa = new SavingsAccount(123, "Lavanya", 10200);
  // Displaying account details
  sa.Display();
  //  Updating balance
  sa.Deposit(3000);
  // Displaying updated balance
  Console.WriteLine("Updated Balance: " + sa.GetBalance());
  }
}