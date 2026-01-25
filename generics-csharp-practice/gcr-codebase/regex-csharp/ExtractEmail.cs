using System;
using System.Text.RegularExpressions;
class ExtractEmail{
    static void Main(string[] args){
        Console.WriteLine("Enter text containing email addresses:");
        string text = Console.ReadLine();
        // Regex pattern to find email addresses
        string pattern = "[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}";
        MatchCollection match = Regex.Matches(text, pattern);
        if(match.Count == 0){
            Console.WriteLine("\nNo email addresses found.");
        }else{
            Console.WriteLine("\nExtracted Email Addresses:");
            for(int i = 0; i < match.Count; i++){
                Console.WriteLine(match[i].Value);
            }
        }
        Console.ReadLine();
    }
}
