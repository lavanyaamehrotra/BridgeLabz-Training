// 7. Create a program to swap two numbers
using System;
class SwapTwoNumbers{
  static void Main(string[] args){
    Console.WriteLine("Enter first number:");
    int number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second Number:");
    int number2=Convert.ToInt32(Console.ReadLine());
    //Swapping numbers
    int temp=number1;
    number1=number2;
    number2=temp;
    Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
  }
}