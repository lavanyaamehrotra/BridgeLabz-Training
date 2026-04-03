//   Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods.
using System;
class UnitConverterTwo{
  static void Main(){
    Console.Write("Enter yards: ");
    double yards = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(yards + " yards = " + ConvertYardsToFeet(yards) + " feet");
    Console.Write("Enter feet: ");
    double feet = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(feet + " feet = " + ConvertFeetToYards(feet) + " yards");
    Console.Write("Enter meters: ");
    double meters = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(meters + " meters = " + ConvertMetersToInches(meters) + " inches");
    Console.Write("Enter inches: ");
    double inches = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(inches + " inches = " + ConvertInchesToMeters(inches) + " meters");
    Console.WriteLine(inches + " inches = " + ConvertInchesToCm(inches) + " cm");
 }// Method to convert yards to feet
  public static double ConvertYardsToFeet(double yards){
    double yardsTofeet = 3;
    return yards * yardsTofeet;
  }
  // Method to convert feet to yards
  public static double ConvertFeetToYards(double feet){
    double feetToyards = 0.333333;
    return feet * feetToyards;
  }
  // Method to convert meters to inches
  public static double ConvertMetersToInches(double meters){
    double metersToinches = 39.3701;
    return meters * metersToinches;
  }
  // Method to convert inches to meters
  public static double ConvertInchesToMeters(double inches){
    double inchesTometers = 0.0254;
    return inches * inchesTometers;
  }// Method to convert inches to centimeters
  public static double ConvertInchesToCm(double inches){
    double inchesTocm = 2.54;
    return inches * inchesTocm;
  }
}
