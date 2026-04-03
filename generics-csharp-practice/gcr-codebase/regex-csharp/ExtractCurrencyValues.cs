using System;
using System.Text.RegularExpressions;
class ExtractCurrencyValues{
    static void Main(string[] args){
        Console.WriteLine("Enter text containing currency values:");
        string text = Console.ReadLine();
        string pattern = "\\$?\\s?\\d+(\\.\\d{2})?";
        MatchCollection match = Regex.Matches(text, pattern);
        if(match.Count == 0){
            Console.WriteLine("\nNo currency values found.");
        }
        else{
            Console.WriteLine("\nExtracted Currency Values:");
            for(int i = 0; i < match.Count; i++){
                string value = match[i].Value.Trim().Replace("$", "");
                Console.WriteLine(value);
            }
        }
        Console.ReadLine();
    }
}
