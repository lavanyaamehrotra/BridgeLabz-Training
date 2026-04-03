// . Convert Text to Lowercase
// Hint => 
// Write a method to convert each character in a string to lowercase using ASCII logic (char manipulation).
// Compare the result with the built-in string.ToLower().
using System;
class TextToLowerCase{
  static void Main(string[] args){
    string input = "BridgeLabz";
    string lower = ToLowercaseASCII(input);
    // Compare with built-in ToLower()
    string builtinLower = input.ToLower();
    Console.WriteLine("Lowercase: " + lower);
    Console.WriteLine("Built-in ToLower(): " + builtinLower);
    Console.WriteLine("are both equal: " + lower.Equals(builtinLower));
  }
  // Method to convert string to lowercase using ASCII
  static string ToLowercaseASCII(string str){
    string result = "";
    foreach (char c in str){
      if (c >= 'A' && c <= 'Z')
        result += (char)(c + 32);
      else
        result += c;
    }
    return result;
  }
}
