// Reverse a String
// Problem:
// Write a C# program to reverse a given string without using any built-in reverse functions.
using System;
class ReverseTheString{
  static void Main(string[] args){
    Console.Write("Enter a string: ");
    string str = Console.ReadLine();
    string reversed = reversestring(str);
    Console.WriteLine("Original String: " + str);
    Console.WriteLine("Reversed String: " + reversed);
  }
  // Method to reverse string
  static string reversestring(string str){
    string ans = "";
    for (int i = str.Length - 1; i >= 0; i--){
      ans += str[i]; 
    }
    return ans;
  }
}
