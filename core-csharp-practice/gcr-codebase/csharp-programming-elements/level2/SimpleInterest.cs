// 11. Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
using System;
class SimpleInterest{     
  static void Main(string[] args){
    Console.WriteLine("Enter the Principal amount:");
    double principal=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Rate of Interest:");
    double rate=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Time in years:");
    double time=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate Simple Interest
    double simpleInterest=(principal*rate*time)/100;
    Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
  }
}     