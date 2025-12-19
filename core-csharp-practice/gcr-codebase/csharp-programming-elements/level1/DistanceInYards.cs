// 14. Write a program to find the distance in yards and miles for the distance provided by the user in feet
using System;
class DistanceInYards{
  static void Main(string[] args){
    Console.WriteLine("Enter the distance in feet:");
    double distanceInFeet=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate distance in yards
    double distanceInYards=distanceInFeet/3;
    //Formula to calculate distance in miles
    double distanceInMiles=distanceInFeet/5280;
    Console.WriteLine("The distance in yards is: " + distanceInYards + " and distance in miles is: " + distanceInMiles);
  }
}