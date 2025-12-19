// 7. Write a Program to compute the volume of Earth in km^3 and miles^3
using System;
class VolumeOfEarth{
  static void Main(string[] args){
    double radius=6378;
    double pi=3.14;
    //formula to calculate volume in cubic kilometers
    double volume=(4.0/3.0)*pi*radius*radius*radius;
    //formula to calculate volume in cubic miles
    double volumeInMiles=volume/(1.6*1.6*1.6);
    Console.WriteLine("The volume of earth in cubic kilometers is " + volume + " and cubic miles is " + volumeInMiles);
  }
}