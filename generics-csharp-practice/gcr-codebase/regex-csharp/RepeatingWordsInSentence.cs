using System;
using System.Text.RegularExpressions;
class RepeatingWordsInSentence{
    static void Main(string[] args){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string pattern = "\\b(\\w+)\\s+\\1\\b";
        MatchCollection match = Regex.Matches(sentence,pattern,RegexOptions.IgnoreCase);
        if(match.Count == 0){
            Console.WriteLine("\nNo repeating words found.");
        }
        else{
            Console.WriteLine("\nRepeating Words:");
            for(int i = 0; i < match.Count; i++){
                Console.WriteLine(match[i].Groups[1].Value);
            }
        }
        Console.ReadLine();
    }
}
