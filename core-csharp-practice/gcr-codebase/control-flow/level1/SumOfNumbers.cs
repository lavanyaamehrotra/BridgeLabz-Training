// Write a program to find the sum of numbers until the user enters 0
using System;
class SumOfNumbers{
  static void Main(string [] args){
    double total=0.0;
    double number;
    Console.WriteLine("Enter a number");
    number=Convert.ToDouble(Console.ReadLine());
    //calculate sum until user enter 0
    while(number!=0){
      total+=number;
      Console.WriteLine("Enter a number");
      number=Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("The total sum is: " + total);
  }
}