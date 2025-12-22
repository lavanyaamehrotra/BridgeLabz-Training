// Write a program to count down the number from the user input value to 1 using a while loop for a rocket launc
using System;
class RocketLaunch{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to start down the countdown");
    int counter=Convert.ToInt32(Console.ReadLine());
    //using while loop to countdown
    while(counter>=1){
      Console.WriteLine(counter);
      counter--;
    }
  }
}