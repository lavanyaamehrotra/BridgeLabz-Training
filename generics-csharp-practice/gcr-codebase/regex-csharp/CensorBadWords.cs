using System;
using System.Text.RegularExpressions;
class CensorBadWords{
    static void Main(string[] args){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string pattern = "\\b(damn|stupid)\\b";
        string censoredText = Regex.Replace(sentence,pattern,"****",RegexOptions.IgnoreCase);
        // Display censored sentence
        Console.WriteLine("\nCensored Output:");
        Console.WriteLine(censoredText);
        Console.ReadLine();
    }
}
