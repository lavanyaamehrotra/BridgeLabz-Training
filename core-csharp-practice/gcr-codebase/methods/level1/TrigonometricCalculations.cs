// Write a program to calculate various trigonometric functions using Math class given an angle in degrees
using System;
class TrigonometricCalculations{
  static void Main(){
    Console.Write("Enter the angle in degrees: ");
    double angle = Convert.ToDouble(Console.ReadLine());
    // Calculate trigonometric functions
    double[] trigValues = calculateTrigonometricFunctions(angle);
      Console.WriteLine("Sine: " + trigValues[0]);
      Console.WriteLine("Cosine: " + trigValues[1]);
      Console.WriteLine("Tangent: " + trigValues[2]);
  }
  public static double[] calculateTrigonometricFunctions(double angle){
    // Convert degrees to radians
    double radians = angle * (Math.PI / 180);
    double sine = Math.Sin(radians);
    double cosine = Math.Cos(radians);
    double tangent = Math.Tan(radians);
    return new double[] { sine, cosine, tangent };
  }
}
