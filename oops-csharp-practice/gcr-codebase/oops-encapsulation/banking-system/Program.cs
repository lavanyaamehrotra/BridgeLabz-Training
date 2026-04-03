using System;
class Program{
    public static void Main(string[] args){ 
        BankAccount acc1 = new SavingsAccount(300000);
        BankAccount acc2 = new CurrentAccount(400000);
        System.Console.WriteLine(acc1.CalculateInterest());
        System.Console.WriteLine(acc2.CalculateInterest());
    }
}
