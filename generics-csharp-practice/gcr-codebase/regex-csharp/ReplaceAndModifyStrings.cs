using System;
using System.Text.RegularExpressions;
class ReplaceAndModifyStrings{
    static void Main(string[] args){
        Console.WriteLine("Enter a sentence with extra spaces:");
        string input = Console.ReadLine();
        string pattern = "\\s+";
        string result = Regex.Replace(input, pattern, " ");
        Console.WriteLine("\nAfter removing extra spaces:");
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
