// Create a program to find the power of a number.
using System;
class PowerOfANumber{
  static void Main(string[] args){
    Console.WriteLine("Enter the base number:");
    int number=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the power:");
    int power=Convert.ToInt32(Console.ReadLine());
    int result=1;
    //iteration to calculate power
    for(int i=1;i<=power;i++){
      result=result*number;
    }
    Console.WriteLine(number + " raised to the power of " + power + " is: " + result);
  }
}