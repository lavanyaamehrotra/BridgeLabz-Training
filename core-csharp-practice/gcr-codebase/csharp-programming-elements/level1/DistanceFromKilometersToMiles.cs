//3. Create a program to convert the distance of 10.8 kilometers to miles.
using System;
class DistanceFromKilometersToMiles{
  static void Main(string[] args){
    double kilometers=10.8;
    //formula to convert kilometers to miles
    double miles=kilometers/1.6;
    Console.WriteLine("The Distance " + kilometers + " km in miles is " + miles);
  }
}