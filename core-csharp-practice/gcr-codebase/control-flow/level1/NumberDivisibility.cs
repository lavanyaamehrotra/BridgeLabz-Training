// Write a program to check if a number is divisible by 5
using System;
class NumberDivisibility{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    //checking if number is divisible by 5 or not
    if(number%5==0){
      Console.WriteLine("Is the number " +number + "divisible by 5? True");
    }
    else{
      Console.WriteLine("Is the number " +number + "divisible by 5? False");
    }
  }
}