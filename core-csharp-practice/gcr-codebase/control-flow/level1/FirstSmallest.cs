// Write a program to check if the first is the smallest of the 3 numbers.
using System;
class FirstSmalest{
  static void Main(string[] args){
    Console.ReadLine("Enter the first number");
    int number1=Convert.ToInt32(Console.ReadLine());
    Console.ReadLine("Enter the second number");
    int number2=Convert.ToInt32(Console.ReadLine());
    Console.ReadLine("Enter the third number");
    int number3=Convert.ToInt32(Console.ReadLine());
    //check if the first number is the smalles
    if(number1<number2 && number1<number3){
      Console.WriteLine("Is the first number the smallest? True");
    }else{
      Console.WriteLine("Is the first number the smallest? False");
    }
  }
}