// Demonstrate IndexOutOfRangeException for Arrays
// Access an invalid index of an array to generate an IndexOutOfRangeException.
// Use try-catch to handle the exception.
using System;
class IndexRangeArray{
  static void Main(string[] args){
    int[] numbers = { 1, 2, 3, 4, 5 };
    int invalidIndex = 10;
    try{
      // throws exception
      int value = numbers[invalidIndex]; 
      Console.WriteLine(value);
    }
    catch (IndexOutOfRangeException ex){
      Console.WriteLine("IndexOutOfRangeException occurred");
      Console.WriteLine(ex.Message);
    }
  }
}
