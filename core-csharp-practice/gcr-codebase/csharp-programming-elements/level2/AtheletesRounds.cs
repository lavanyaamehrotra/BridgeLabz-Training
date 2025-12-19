// 9. An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete?
using System;
class AtheletesRounds{
  static void Main(string[] args){
    Console.WriteLine("Enter side1 of the triangualar park in meters:");
    double side1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter side2 of the triangualar park in meters:");
    double side2=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter side3 of the triangualar park in meters:");
    double side3=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate perimeter of triangle
    double perimeter=side1+side2+side3;
    //Total distance to be run in meters
    double totalDistance=5000;
    //Formula to calculate total rounds
    double totalRounds=totalDistance/perimeter;
    Console.WriteLine("The total number of rounds the athlete will run is: " + total  Rounds + " to complete 5 km");  
  }
}