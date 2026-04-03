// Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods.
using System;
class UnitConverter{
  static void Main(){
    Console.Write("Enter kilometers: ");
    double km = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(km + " km = " + ConvertKmToMiles(km) + " miles");
    Console.Write("Enter miles: ");
    double miles = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(miles + " miles = " + ConvertMilesToKm(miles) + " km");
    Console.Write("Enter meters: ");
    double meters = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(meters + " meters = " + ConvertMetersToFeet(meters) + " feet");
    Console.Write("Enter feet: ");
    double feet = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(feet + " feet = " + ConvertFeetToMeters(feet) + " meters");
  }
  // Method to convert kilometers to miles
  public static double ConvertKmToMiles(double km){
    double kmToMiles = 0.621371;
    return km * kmToMiles;
  }
  // Method to convert miles to kilometers
  public static double ConvertMilesToKm(double miles){
    double milesToKm = 1.60934;
    return miles * milesToKm;
  }
  // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters){
      double metersToFeet = 3.28084;
      return meters * metersToFeet;
    }
    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet){
      double feetToMeters = 0.3048;
      return feet * feetToMeters;
    }
}
