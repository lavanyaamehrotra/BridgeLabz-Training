// Convert Text to Uppercase
// Hint => 
// Write a method to convert each character in a string to uppercase using ASCII logic (char manipulation).
// Compare the result with the built-in string.ToUpper().
using System;
class TextToUpperCase{
  static void Main(string[] args){
    string input = "BridgeLabz";
    string uppercase = ConvertToUpper(input);
    string builtinUpper = input.ToUpper();
    Console.WriteLine("Uppercase: " + uppercase);
    Console.WriteLine("Built-in: " + builtinUpper);
    Console.WriteLine("are both equal: " + uppercase.Equals(builtinUpper));
  }
  // Method to convert string to uppercase using ASCII values
  static string ConvertToUpper(string str){
    string result = "";
    foreach (char c in str){
      if (c >= 'a' && c <= 'z') 
        result += (char)(c - 32); // convert to uppercase using ASCII
      else
        result += c;
      }
    return result;
  }
}
