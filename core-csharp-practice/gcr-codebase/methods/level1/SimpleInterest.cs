// Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
using System;
class SimpleInterest{
  static void Main(string[] args){
    Console.WriteLine("Enter the Principal amout: ");
    double principal=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Rate of Interest: ");
    double rate=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Time");
    double time=Convert.ToDouble(Console.ReadLine());
    double interest = CalculateSimpleInterest(principal, rate, time);
    Console.WriteLine("The Simple Interest is: " + interest);
  }
  static double CalculateSimpleInterest(double principal, double rate, double time){
    double simpleInterest=(principal*rate*time)/100;
    return simpleInterest;
  }
}