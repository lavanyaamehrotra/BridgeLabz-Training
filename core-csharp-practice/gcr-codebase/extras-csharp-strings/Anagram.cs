// Write a C# program that accepts two strings from the user and checks if the two
// strings are anagrams of each other (i.e., whether they contain the same characters in any
// order).
using System;
class Anagram{
  static void Main(string[] args){
    Console.Write("Enter first string: ");
    string str1 = Console.ReadLine().ToLower().Replace(" ", "");
    Console.Write("Enter second string: ");
    string str2 = Console.ReadLine().ToLower().Replace(" ", "");
    if (IsAnagrams(str1, str2)){
      Console.WriteLine("The strings are anagrams.");
    }else{
      Console.WriteLine("The strings are not anagrams.");
    }
  }
  // Method to check if two strings are anagrams
  static bool IsAnagrams(string s1, string s2){
    if (s1.Length != s2.Length){
      return false;
    }
    int[] count = new int[256]; // count array for all ASCII chars
    // Count characters in s1
    foreach (char c in s1){
      count[c]++;
    }
    foreach (char c in s2){
      count[c]--;
      if (count[c] < 0){
        return false; 
      }
      return true;
    }
  }
}
