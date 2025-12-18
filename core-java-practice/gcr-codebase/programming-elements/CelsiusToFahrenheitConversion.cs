using System;
namespace ProgrammingElements{
    class CelsiusToFahrenheitConversion{
        static void Main(string[] args){
            // Write a program that takes temperature in Celsius as input
            // and converts it to Fahrenheit
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            onsole.WriteLine("Fahrenheit: " + fahrenheit);
        }
    }
}
