// Write a program to check whether a number is positive, negative, or zero.
using System;
class PositiveNegativeOrZero{
  static void Main(string[] args){
    Console.WriteLine("Enter a number:");
    int number=Convert.ToInt32(Console.ReadLine());
    //if number greater than 0 then positive
    if(number>0){
      Console.WriteLine("positive");
    }
    //if number less than 0 then negative
    else if(number<0){
      Console.WriteLine("negative");
    }
    else{
      Console.WriteLine("zero");
    }
  }
}