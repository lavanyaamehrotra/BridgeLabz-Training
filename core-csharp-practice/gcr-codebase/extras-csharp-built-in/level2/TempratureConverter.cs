// Temperature Converter:
// Write a program that converts temperatures between Fahrenheit and Celsius.
// ● The program should have separate functions for converting from Fahrenheit to
// Celsius and from Celsius to Fahrenheit.
using System;
class TemperatureConverter{
    // Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double c){
        return (c * 9.0 / 5.0) + 32;
    }

    // Fahrenheit to Celsius
    static double FahrenheitToCelsius(double f){
        return (f - 32) * 5.0 / 9.0;
    }
    static void Main(string[] args){
        Console.Write("Enter temperature in Celsius: ");
        double cel = Convert.ToDouble(Console.ReadLine());
        double fahrenAns = CelsiusToFahrenheit(cel);
        Console.WriteLine($"{cel} = {fahrenAns:F2}");
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahren = Convert.ToDouble(Console.ReadLine());
        double celAns = FahrenheitToCelsius(fahren);
        Console.WriteLine($"{fahren}= {celAns:F2}");
    }
}
