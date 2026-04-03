// Find the Most Frequent Character
// Problem:
// Write a C# program to find the most frequent character in a string.
// Example Input:
// String: "success"
// Expected Output:
// Most Frequent Character: 's'
using System;
class MostFrequentCharacter{
  static void Main(string[] args){
    Console.Write("Enter a string: ");
    string str = Console.ReadLine();
    int[] freq = new int[256];
    foreach (char ch in str)
      freq[ch]++;
    char mostfrequent = str[0];
    //looping to find out
    for (int i = 1; i < str.Length; i++){
      if (freq[str[i]] > freq[mostfrequent]){
        mostfrequent = str[i];
      }
    }
    Console.WriteLine("Most Frequent Character:" + mostfrequent);
  }
}
