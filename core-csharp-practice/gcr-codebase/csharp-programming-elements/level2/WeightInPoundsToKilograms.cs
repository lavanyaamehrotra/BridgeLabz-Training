// 12. Create a program to convert weight in pounds to kilograms.
using System;
class WeightInPoundsToKilograms{      
  static void Main(string[] args){
      Console.WriteLine("Enter weight in pounds:");
      double weightInPounds=Convert.ToDouble(Console.ReadLine());
      //Formula to convert pounds to kilograms
      double weightInKilograms=weightInPounds/2.2;
      Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKilograms);
    }
}   