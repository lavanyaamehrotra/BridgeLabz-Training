// Write a program to check for the natural number and write the sum of n natural numbers 
using System;
class SumOfNaturalNumbers{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    //checking if the number is natural number
    if(number>0){
      int sum=(number*(number+1))/2;
      Console.WriteLine("The Sum of " + number + " natural number is " +sum);
    }
  }
}
