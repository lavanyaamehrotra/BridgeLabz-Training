// Demonstrate ArgumentOutOfRangeException
// Hint => 
// Use string.Substring() with start index greater than the end index to generate an ArgumentOutOfRangeException.
// Use try-catch to handle the exception
using System;
class ArgumentRange{
  static void Main(string[] args){
    string text = "BridgeLabz";
    int startIndex = 8;
    int length = 5;
    try{
      string sub = text.Substring(startIndex, length); // throws exception
      Console.WriteLine(sub);
    }
    catch (ArgumentOutOfRangeException ex){
      Console.WriteLine("ArgumentOutOfRangeException occurred!");
      Console.WriteLine(ex.Message);
    }
  }
}

