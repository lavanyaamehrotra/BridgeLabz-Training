// 10. Write a program that takes your height in centimeters and converts it into feet and inches
using System;
class HeightInCmAndFeetAndInchs{
  static void Main(string[] args){
    double heightInCm=Convert.ToDouble(Console.ReadLine());
    //formula to convert height in cm to inches
    double heightInInches=heightInCm/2.54;
    //formula to convert height in inches to feet
    double heightInFeet=heightInInches/12;
    Console.WriteLine("Your Height in cm is " + heightInCm + " while in feet is " + heightInFeet + " and inches is " + heightInInches);
  }
}


