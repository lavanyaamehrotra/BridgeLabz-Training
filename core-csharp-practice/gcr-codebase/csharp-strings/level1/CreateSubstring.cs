//Create a Substring Using charAt()
// Take user input using Console.ReadLine() for string, start index, and end index.
// Write a method to create a substring using charAt() (string[index] in C#).
// Use string.Substring() to generate the substring and compare the results.
using System;
class CreateSubstring{
  static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter starting index: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter ending index: ");
        int end = int.Parse(Console.ReadLine());
        string RealSubstring = CreateSubstringUsingCharAt(input, start, end);
        string builtinSubstring = input.Substring(start, end - start);
        Console.WriteLine($"substring: {RealSubstring}");
        Console.WriteLine($"Substring() result: {builtinSubstring}");
        Console.WriteLine($"are both substrings equal:{RealSubstring.Equals(builtinSubstring)}");
  }
  // Method that builds substring
  static string CreateSubstringUsingCharAt(string str, int start, int end){
    string result = "";
      for (int i = start; i < end; i++){
          result += str[i];
      }
    return result;
  }
}
