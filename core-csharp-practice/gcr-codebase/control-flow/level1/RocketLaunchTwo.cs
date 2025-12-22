// Rewrite program 8 to do the countdown using the for-loop
// Write a program to count down the number from the user input value to 1 using a for loop for a rocket launch
using System;
class RocketLaunchTwo{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to start down countdown");
    int counter=Convert.ToInt32(Console.ReadLine());
    //using for loop to countdown
    for(int i=counter;i>=1;i--){
      Console.WriteLine(i);
    }
    
  }
}