// Remove a Specific Character from a String
// Problem:
// Write a C# program to remove all occurrences of a specific character from a string.
// Example Input:
// String: "Hello World"
// Character to Remove: 'l'
// Expected Output:
// Modified String: "Heo Word"
using System;
class RemoveCharacter{
  static void Main(string[] args){
    //take user input
    Console.Write("Enter a string: ");
    string str = Console.ReadLine();
    Console.Write("Enter the char: ");
    char ch = Console.ReadKey().KeyChar;
    Console.WriteLine();
    string ans = "";
    //loop for adding
    for (int i = 0; i < str.Length; i++){
      if (str[i] != ch){
        ans += str[i];
      }
    }
    //print 
    Console.WriteLine("After removal : " + ans);
  }
}
