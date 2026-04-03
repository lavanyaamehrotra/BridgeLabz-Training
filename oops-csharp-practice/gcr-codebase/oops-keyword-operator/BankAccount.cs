using System;
class BankAccount{
  // Static variable shared across all accounts
  public static string bankName = "Bank of Baroda";
  // Static variable to keep track of total accounts
  private static int totalAccount = 0;
  // Readonly variable for Account Number
  public readonly int AccountNumber;
  // Instance variables
  public string AccountHolder;
  public double Balance;
  // Constructor 
    public BankAccount(string AccountHolder, int AccountNumber, double Balance){
      this.AccountHolder = AccountHolder; 
      this.AccountNumber = AccountNumber;
      this.Balance = Balance;
      totalAccount++;
    }
    // Static method to get total accounts
    public static void GetTotalAccounts(){
        Console.WriteLine($"Total accounts in {bankName}: {totalAccount}");
    }
    // Method to display account details
    public void DisplayAccount(){
      // Checking if this object is an instance of BankAccount
      if (this is BankAccount){
        Console.WriteLine($"Bank Name: {bankName}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: ${Balance}");
      }else{
        Console.WriteLine("Not a valid bankaccoun object.");
      }
    }
}
class Program{
  static void Main(string[] args){
    // Create bank accounts
    BankAccount account1 = new BankAccount("Lavanya", 123, 4000);
    BankAccount account2 = new BankAccount("Khushi", 321, 6500);
    // Display account info
    account1.DisplayAccount();
    Console.WriteLine();
    account2.DisplayAccount();
    Console.WriteLine();
    // Display total accounts
    BankAccount.GetTotalAccounts();
  }
}
