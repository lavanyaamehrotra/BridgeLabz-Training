// Demonstrate FormatException
// Hint => 
// Use int.Parse() on a non-numeric string to generate FormatException.
// Use try-catch to handle the exception.
using System;
class Format{
  static void Main(string[] args){
    string input = "Bridge123";
    try{
      int number = int.Parse(input);
      Console.WriteLine(number);
    }
    catch (FormatException ex){
      Console.WriteLine("FormatException occurred");
      Console.WriteLine(ex.Message);
    }
  }
}
