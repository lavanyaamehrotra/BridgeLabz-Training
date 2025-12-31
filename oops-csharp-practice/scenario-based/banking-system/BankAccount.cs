using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops.banking_system{
    internal class BankAccount{
        // Basic account details
        public string AccountNumber;
        public string AccountHolder;
        public double Balance;

        // Additional details
        public string BankName;
        public string BranchName;
        public string IFSC;
        public string City;

        public BankAccount(string accNo, string holder, double balance, string bankName,string branchName, string ifsc, string city){
            AccountNumber = accNo;
            AccountHolder = holder;
            Balance = balance;
            BankName = bankName;
            BranchName = branchName;
            IFSC = ifsc;
            City = city;
        }

        public void Deposit(double amount){
            if (amount <= 0){
                Console.WriteLine("Deposit amount > 0.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited Rs{amount}. New Balance = Rs{Balance}");
        }
        public void Withdraw(double amount){
            if (amount <= 0){
                Console.WriteLine("Withdraw amount > 0");
                return;
            }

            if (amount > Balance){
                Console.WriteLine("Insufficient balance");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrawn rs{amount}. Remaining Balance = Rs{Balance}");
        }

        public void CheckBalance(){
            Console.WriteLine($"Current Balance: rs{Balance}");
        }

        public void ShowAccountDetails(){
            Console.WriteLine("\n====== ACCOUNT DETAILS ======");
            Console.WriteLine($"Account Holder : {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Bank Name : {BankName}");
            Console.WriteLine($"Branch Name: {BranchName}");
            Console.WriteLine($"IFSC Code: {IFSC}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Balance: rs{Balance}");
        }
    }
}