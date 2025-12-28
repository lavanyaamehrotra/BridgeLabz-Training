// Palindrome Checker:
// Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
// that reads the same backward as forward).
// ● Break the program into functions for input, checking the palindrome condition, and
// displaying the result.
using System;
class PalindromeChecker{
  static void Main(string[] args){
    string input = GetInput();
    bool isPalindrome = CheckPalindrome(input);
    displayAns(input, isPalindrome);
  }
  // Function to get user input
  static string GetInput(){
    Console.Write("Enter the word or phrase: ");
    return Console.ReadLine().ToLower().Replace(" ", "");
  }
  // Function to check if the string is a palindrome
  static bool CheckPalindrome(string str){
    int left = 0;
    int right = str.Length - 1;
    while (left < right){
    if (str[left] != str[right]){
      return false;
    }
    left++;
    right--;
  }
  return true;
  }
  // Function to display the result
  static void displayAns(string old, bool isPalindrome){
    if (isPalindrome){
      Console.WriteLine($"'{old}' is a palindrome.");
    }else{
      Console.WriteLine($"'{old}' is not a palindrome.");
    }
  }
}
