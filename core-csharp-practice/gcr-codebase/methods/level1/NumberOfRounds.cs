// An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete
using System;
class NumberOfRounds{
  static void Main(string[] args){
    Console.WriteLine("Enter the first side ");
    double side1=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second side ");
    double side2=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the third size ");
    double side3=Convert.ToDouble(Console.ReadLine());
    double rounds=CalculateRounds(side1,side2,side3);
    Console.WriteLine("The number of rounds to complete 5km run is: " + rounds);
  }
  static double CalculateRounds(double side1,double side2 ,double side3){
    //formula to calculate perimeter
    double perimeter=side1+side2+side3;
    double distance=5000;
    //calculating number of rounds
    double rounds=distance/perimeter;
    return rounds;
  } 
}