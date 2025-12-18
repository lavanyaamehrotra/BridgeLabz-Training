using System;
namespace ProgrammingElements{
    class CalculateSimpleInterest{
        static void Main(string[] args){
            // write a program to calculate the simple interest
            double p = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            // calculate simple interest
            double simpleInterest = (p * r * t) / 100;
            // print the simple interest
            Console.WriteLine("Simple Interest is " + simpleInterest);
        }
    }
}
