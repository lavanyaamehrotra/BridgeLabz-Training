// 5. Write a TemperatureConversion program, given the temperature in Fahrenheit as input that outputs the temperature in Celsius
using System;
class FahrenheitToCelsius{
  static void Main(string[] args){
    Console.WriteLine("Enter the temprature in Fahrenheit:");
    double fahrenheit=Convert.ToDouble(Console.ReadLine());
    //Formula to convert fahrenheint to celsius
    double celsiusResult=(fahrenheint-32)*5/9;
    Console.WriteLine("The " + fahrenheint + " Fahrenheit is " + celsiusResult + " Celsius");
  }
}