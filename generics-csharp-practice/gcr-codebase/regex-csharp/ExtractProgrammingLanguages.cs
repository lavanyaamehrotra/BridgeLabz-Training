using System;
using System.Text.RegularExpressions;
class ExtractProgrammingLanguages{
    static void Main(string[] args){
        Console.WriteLine("Enter a sentence containing programming languages:");
        string text = Console.ReadLine();
        string pattern = "\\b(Java|Python|JavaScript|Go|C|C\\+\\+|C#|Ruby|PHP)\\b";
        MatchCollection match = Regex.Matches(text,pattern,RegexOptions.IgnoreCase);
        if(match.Count == 0){
            Console.WriteLine("\nNo programming languages found.");
        }
        else{
            Console.WriteLine("\nExtracted Programming Languages:");
            for(int i = 0; i < match.Count; i++){
                Console.WriteLine(match[i].Value);
            }
        }
        Console.ReadLine();
    }
}
