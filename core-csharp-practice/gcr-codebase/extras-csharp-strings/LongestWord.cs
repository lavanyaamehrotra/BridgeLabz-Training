//Find the Longest Word in a Sentence
// Problem:
// Write a C# program that takes a sentence as input and returns the longest word in the
// sentence.
using System;
class LongestWord{
  static void Main(string[] args){
    Console.Write("Enter the sentence: ");
    string sentence = Console.ReadLine();
    string longest = FindLongestWord(sentence);
    Console.WriteLine("Longest Word: " + longest);
  }
  // Method to find longest word 
  static string FindLongestWord(string str){
    string current = "";
    string longest = "";
    for (int i = 0; i < str.Length; i++){
      char ch = str[i];
      if (ch != ' '){
        current += ch;
      }else{
        // word ended : checking length
        if (current.Length > longest.Length)
          longest = current;
          current = "";
        }
    }
    // Check last word after loop
    if (current.Length > longest.Length){
      longest = current;
    }
    return longest;
  }
}
