using System;
using System.Collections.Generic;
class BankingSystem{
    static Dictionary<int, double> accounts = new Dictionary<int, double>();
    static SortedDictionary<double, List<int>> sortedAccounts = new SortedDictionary<double, List<int>>();
    static Queue<(int accountId, double amount)> withdrawalQueue = new Queue<(int, double)>();
    static void Main(){ 
        // Sample Data
        AddAccount(101, 5000);
        AddAccount(102, 12000);
        AddAccount(103, 3000);
        AddAccount(104, 8000);
        Console.WriteLine("Initial Accounts:");
        DisplayAccounts();
        EnqueueWithdrawal(101, 1000);
        EnqueueWithdrawal(103, 500);
        EnqueueWithdrawal(102, 2000);
        Console.WriteLine("\nProcessing Withdrawals...");
        ProcessWithdrawal();
        Console.WriteLine("\nFinal Account Balances:");
        DisplayAccounts();
        Console.WriteLine("\nAccounts Sorted By Balance:");
        DisplaySortedAccounts();
    }
    // Add or Update Account
    static void AddAccount(int accountId, double balance){
        accounts[accountId] = balance;
        UpdateSortedAccounts();
    }
    // Queue withdrawal requests
    static void EnqueueWithdrawal(int accountId, double amount){
        withdrawalQueue.Enqueue((accountId, amount));
    }
    // Process withdrawal queue
    static void ProcessWithdrawal(){
        while (withdrawalQueue.Count > 0){
            var (accountId, amount) = withdrawalQueue.Dequeue();
            if (!accounts.ContainsKey(accountId)){
                Console.WriteLine($"Account {accountId} not found.");
                continue;
            }
            if (accounts[accountId] >= amount){
                accounts[accountId] -= amount;
                Console.WriteLine($"Withdrawal successful: Rs{amount} from Account {accountId}");
            }
            else{
                Console.WriteLine($"insufficient balance for Account {accountId}");
            }
        }
        UpdateSortedAccounts();
    }
    // Display all accounts
    static void DisplayAccounts(){
        foreach (var acc in accounts){
            Console.WriteLine($"Account: {acc.Key}, Balance: Rs{acc.Value}");
        }
    }
    // Update sorted structure
    static void UpdateSortedAccounts(){
        sortedAccounts.Clear();
        foreach (var acc in accounts){
            if (!sortedAccounts.ContainsKey(acc.Value)){
                sortedAccounts[acc.Value] = new List<int>();
            }
            sortedAccounts[acc.Value].Add(acc.Key);
        }
    }
    // Display sorted by balance
    static void DisplaySortedAccounts(){
        foreach (var entry in sortedAccounts){
            foreach (var accId in entry.Value){
                Console.WriteLine($"Account: {accId}, Balance:Rs{entry.Key}");
            }
        }
    }
}
