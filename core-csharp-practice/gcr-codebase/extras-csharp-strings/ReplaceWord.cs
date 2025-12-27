// Write a replace method in C# that replaces a given word with another word in a sentence:
using System;
class ReplaceWord{
  static void Main(string[] args){
    Console.Write("Enter a sentence: ");
    string sentence = Console.ReadLine();
    Console.Write("Enter the word to replace: ");
    string previousword = Console.ReadLine();
    Console.Write("Enter the new word: ");
    string newword = Console.ReadLine();
    //replacement
    string ans = sentence.Replace(previousword, newword);
    Console.WriteLine("after replacement : " + ans);
  }
}
