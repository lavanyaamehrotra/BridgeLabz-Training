using System;
namespace ProgrammingElements{
    class PowerCalculation{
        static void Main(string[] args){
            // take the base input
            double baseValue = double.Parse(Console.ReadLine());
             // take the exponent input
            double exponent = double.Parse(Console.ReadLine());
            // calculate the result
            double result = Math.Pow(baseValue, exponent);
            // print the result
            Console.WriteLine("Result = " + result);
        }
    }
}
