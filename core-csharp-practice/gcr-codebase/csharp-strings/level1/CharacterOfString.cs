//Return All Characters Without Using ToCharArray()
// Hint => 
// Write a method to return characters of a string without using ToCharArray() (loop through string[index]).
// Compare the result with the built-in ToCharArray() method.
using System;
class CharacterOfString{
  static void Main(){
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();
    char[] realChars = GetCharswithoutToCharArray(input);
    char[] builtinChars = input.ToCharArray();
    Console.WriteLine("Characters using real method:");
    PrintChars(realChars);
    Console.WriteLine("Characters using ToCharArray():");
    PrintChars(builtinChars);
    Console.WriteLine($"are both character arrays equal: {CompareArrays(realChars, builtinChars)}");
  }
  // Return characters
  static char[] GetCharwithoutToCharArray(string str){
    char[] result = new char[str.Length];
    for (int i = 0; i < str.Length; i++){
      result[i] = str[i];
    }
    return result;
  }
  // Compare two char arrays
  static bool CompareArrays(char[] a, char[] b){
    if (a.Length != b.Length)
      return false;
    for (int i = 0; i < a.Length; i++){
      if (a[i] != b[i])
        return false;
    }
    return true;
  }
  // print characters
  static void PrintChars(char[] arr){
    foreach (char c in arr){
      Console.Write(c + " ");
    }
    Console.WriteLine();
  }
}
