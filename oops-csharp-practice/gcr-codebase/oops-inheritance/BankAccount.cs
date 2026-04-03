using System;
class BankAccount{
  public string AccountNumber;
  public double Balance;
  public BankAccount(string accountNumber, double balance){
    AccountNumber = accountNumber;
    Balance = balance;
  }
  public void DisplayCommonDetails(){
    Console.WriteLine("Account Number: " + AccountNumber);
    Console.WriteLine("Balance: " + Balance);
  }
}
class SavingsAccount : BankAccount{
  public double InterestRate;
  public SavingsAccount(string accountNumber, double balance, double interestRate): base(accountNumber, balance){
    InterestRate = interestRate;
  }
  public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Savings Account");
        DisplayCommonDetails();
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

class CheckingAccount : BankAccount
{
    public double WithdrawalLimit;

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Checking Account");
        DisplayCommonDetails();
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

class FixedDepositAccount : BankAccount
{
    public int PeriodMonths;

    public FixedDepositAccount(string accountNumber, double balance, int period)
        : base(accountNumber, balance)
    {
        PeriodMonths = period;
    }

    public void DisplayAccountType()
    {
        Console.WriteLine("\nAccount Type: Fixed Deposit Account");
        DisplayCommonDetails();
        Console.WriteLine("Lock-in Period: " + PeriodMonths + " months");
    }
}

class Program{
    static void Main(){
        SavingsAccount savingaccounts = new SavingsAccount("SA1", 25000, 6.5);
        CheckingAccount checkingaccounts = new CheckingAccount("CA1", 18000, 5000);
        FixedDepositAccount fixeddepositaccount = new FixedDepositAccount("FD1", 100000, 24);
        savingaccounts.DisplayAccountType();
        checkingaccounts.DisplayAccountType();
        fixeddepositaccount.DisplayAccountType();

        Console.ReadLine();
    }
}
