// 1. Write a program to take 2 numbers and print their quotient and remainder
using System;
class QuotientAndRemainder{
  static void Main(string[] args){
    Console.WriteLine("Enter first number:");
    int number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int number2=Convert.ToInt32(Console.ReadLine());
    //Formula to calculate quotient
    int quotient=number1/number2;
    //formula to calculate remainder
    int remainder=number1%number2;
    Console.WriteLine("The Quotient is " + quotient + " and Reamainder is " + remainder + " of two numbers " + number1 + " and " + number2);
  }
}