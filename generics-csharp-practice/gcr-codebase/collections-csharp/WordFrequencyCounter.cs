using System;
using System.Collections.Generic;
using System.IO;
class WordFrequencyCounter{
    static void Main(){
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();
        if (!File.Exists(path)){
            Console.WriteLine("File not found.");
            return;
        }
        string text = File.ReadAllText(path);
        // Convert to lowercase and remove punctuation
        char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };
        string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words){
            if (wordCount.ContainsKey(word)){
                wordCount[word]++;
            }else{
                wordCount[word] = 1;
            }
        }
        Console.WriteLine("\nWord Frequencies:");
        foreach (var pair in wordCount){
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}
