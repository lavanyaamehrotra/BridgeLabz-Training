using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CountWordsInFile{
    static void Main(){
        string filePath = "sample.txt";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        using (StreamReader reader = new StreamReader(filePath)){
            string line;
            while ((line = reader.ReadLine()) != null){
                string[] words = line.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t' },StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words){
                    if (wordCount.ContainsKey(word)){
                        wordCount[word]++;
                    }else{
                        wordCount[word] = 1;
                    }
                }
            }
        }
        Console.WriteLine("Top 5 most frequent words are:\n");
        foreach (var item in wordCount.OrderByDescending(x => x.Value).Take(5)){
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
        Console.ReadLine();
    }
}
