// Compare Two Strings
// Problem:
// Write a C# program to compare two strings lexicographically (dictionary order) without
// using built-in compare methods.
// Example Input:
// String 1: "apple"
// String 2: "banana"
using System;
class CompareTwoStrings{
  static void Main(string[] args){
    Console.WriteLine("Enter string: ");
    string str1 = Console.ReadLine();
    Console.WriteLine("Enter string: ");
    string str2 = Console.ReadLine();
    int minimum = Math.Min(str1.Length, str2.Length);
    int ans = 0;
    // Compare character by character
    for (int i = 0; i < minimum; i++){
      if (str1[i] != str2[i]){
        ans = str1[i] - str2[i];
        break;
      }
    }
    // If all characters matched but lengths differ
    if (ans == 0 && str1.Length != str2.Length){
      ans = str1.Length - str2.Length;
    }
    if (ans == 0){
      Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal in lexicographical order");
    }else if (ans < 0){
      Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
    }else{
      Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order");
    }
  }
}
