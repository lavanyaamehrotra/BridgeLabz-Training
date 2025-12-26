// Demonstrate NullReferenceException
// Write a method to demonstrate NullReferenceException by accessing a method on a null string.
// Use a try-catch block to handle the exception.

using System;
class NullReference{
  static void Main(){
        DemonstrateNullReference();
  }
  static void DemonstrateNullReference(){
    string str = null; 
    try{
      Console.WriteLine("Attempting to access string length...");
      // This will throw NullReferenceException
      int length = str.Length;
      Console.WriteLine($"String length: {length}");
    }
    catch (NullReferenceException ex){
      Console.WriteLine("NullReferenceException is occurring");
      Console.WriteLine($"Exception Message: {ex.Message}");
    }
  }
}
