// Palindrome String Check
// Problem:
// Write a C# program to check if a given string is a palindrome (a string that reads the
// same forward and backward).
using System;
class PalindromeString{
  static void Main(string[] args){
    Console.Write("Enter the string: ");
    string str = Console.ReadLine();
    bool isPalindrome = IsPalindrome(str);
    if (isPalindrome)
      Console.WriteLine("the string is a palindrome");
    else
      Console.WriteLine("the string is not a palindrome");
  }
  // Method to check palindrome
  static bool isPalindrome(string str){
    str = str.ToLower();
    int start = 0;
    int end = str.Length - 1;
    while (start < end){
      if (str[start] != str[end]){
        return false;
      }
      start++;
      end--;
    }
    return true;
  }
}
