//   Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g. 
using System;
class UnitConverterThree{
  // Method to convert Fahrenheit to Celsius
  public static double ConvertFahrenheitToCelsius(double fahrenheit){
    double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
    return fahrenheit2celsius;
  }
  // Method to convert Celsius to Fahrenheit
  public static double ConvertCelsiusToFahrenheit(double celsius){
    double celsius2fahrenheit = (celsius * 9 / 5) + 32;
    return celsius2fahrenheit;
  }
  // Method to convert pounds to kilograms
  public static double ConvertPoundsToKilograms(double pounds){
    double pounds2kilograms = 0.453592;
    return pounds * pounds2kilograms;
  }
  // Method to convert kilograms to pounds
  public static double ConvertKilogramsToPounds(double kilograms){
    double kilograms2pounds = 2.20462;
    return kilograms * kilograms2pounds;
  }
  // Method to convert gallons to liters
  public static double ConvertGallonsToLiters(double gallons){
    double gallons2liters = 3.78541;
    return gallons * gallons2liters;
  }
  // Method to convert liters to gallons
  public static double ConvertLitersToGallons(double liters){
    double liters2gallons = 0.264172;
    return liters * liters2gallons;
  }
  static void Main(){
    Console.Write("Enter temperature in Fahrenheit: ");
    double fahrenheit = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(fahrenheit + ConvertFahrenheitToCelsius(fahrenheit));
    Console.Write("Enter temperature in Celsius: ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(celsius  + ConvertCelsiusToFahrenheit(celsius));
    Console.Write("Enter weight in pounds: ");
    double pounds = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(pounds + " lbs = " + ConvertPoundsToKilograms(pounds) + " kg");
    Console.Write("Enter weight in kilograms: ");
    double kilograms = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(kilograms + " kg = " + ConvertKilogramsToPounds(kilograms) + " lbs");
    Console.Write("Enter volume in gallons: ");
    double gallons = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(gallons + " gallons = " + ConvertGallonsToLiters(gallons) + " liters");
    Console.Write("Enter volume in liters: ");
    double liters = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(liters + " liters = " + ConvertLitersToGallons(liters) + " gallons");
  }
}
