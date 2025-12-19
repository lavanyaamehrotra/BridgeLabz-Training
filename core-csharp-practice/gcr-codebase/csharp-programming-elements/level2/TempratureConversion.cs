// 4. Write a TemperatureConversion program, given the temperature in Celsius as input that outputs the temperature in Fahrenheit
using System;
class TemperatureConversion{
  static void Main(string[] args){
    Console.WriteLine("Enter the temperature in celsius:");
    double celsius=Convert.ToDouble(Console.ReadLine());
    //Formula to convert celsius to fahrenheit
    double fahrenheitResult=(celsius*9/5)+32;
    Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
  }
}