// .Write a program calculate the wind chill temperature given the temperature and wind speed
using System;
class WindChillTemprature{
  static void Main(){
    Console.Write("Enter the temperature: ");
    double temperature = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the wind speed : ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    // Calculate wind chill
    double windChill = CalculateWindChill(temperature, windSpeed);
    Console.WriteLine("The wind chill temperature is: " + windChill);
  }
  // Method to calculate wind chill
  public static double CalculateWindChill(double temperature, double windSpeed){
    double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    return windChill;
  }
}
