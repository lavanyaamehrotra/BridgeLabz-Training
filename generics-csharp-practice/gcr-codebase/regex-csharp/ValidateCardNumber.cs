using System;
using System.Text.RegularExpressions;
class ValidateCardNumber{
    static void Main(string[] args){
        Console.WriteLine("Enter credit card number:");
        string cardNumber = Console.ReadLine();
        string pattern = "^(4\\d{15}|5\\d{15})$";
        if(Regex.IsMatch(cardNumber, pattern)){
            Console.WriteLine("Valid Credit Card Number");
        }
        else{
            Console.WriteLine("Invalid Credit Card Number");
        }
        Console.ReadLine();
    }
}
