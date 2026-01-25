using System;
using System.Text.RegularExpressions;
class SocialSecurityNumber{
    static void Main(string[] args){
        Console.WriteLine("Enter a text containing SSN:");
        string text = Console.ReadLine();
        string pattern = "\\b\\d{3}-\\d{2}-\\d{4}\\b";
        Match match = Regex.Match(text, pattern);
        if(match.Success){
            Console.WriteLine("Valid SSN");
            Console.WriteLine("SSN Found: " + match.Value);
        }
        else{
            Console.WriteLine("Invalid SSN");
        }
        Console.ReadLine();
    }
}
