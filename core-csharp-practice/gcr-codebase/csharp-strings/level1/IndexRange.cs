//  Demonstrate IndexOutOfRangeException
// Hint => 
// Access an invalid index of a string using charAt() (string[index] in C#) to generate the exception.
// Write another method with try-catch to handle the exception.
using System;
class IndexRange{
  static void Main(string[] args){
    // Without handling
    string str = "BridgeLabz";
    char ch = str[12]; // throws exception
    Console.WriteLine(ch);
    // With try-catch
    try{
      char ch2 = str[12];
      Console.WriteLine(ch2);
    }
    catch (IndexOutOfRangeException ex){
      Console.WriteLine("IndexOutOfRangeException occurred");
      Console.WriteLine(ex.Message);
    }
  }
}

