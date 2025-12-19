// 8. Create a program to convert distance in kilometers to miles.
using System;
class KilometersToMiles{
  static void Main(string[] args){
    Console.WriteLine("Enter distance in kilometers:");
    double km=ConvertToDouble(Console.WriteLine());
    //formula to convert kilometers to miles 
    double miles=km/1.6;
    Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
  }
}