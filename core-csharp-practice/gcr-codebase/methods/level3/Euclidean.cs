//  Write a program Euclidean distance between two points as well as the equation of the line using those two points. Use Math functions Math.Pow() and Math.Sqrt()
using System;
class Euclidean{
    public static double Distance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    public static double[] LineEquation(double x1, double y1, double x2, double y2){
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }
    public static void Main(){
        //inputs
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        //calling distance method
        double dist = Distance(x1, y1, x2, y2);
        Console.WriteLine("Distance: " + dist);
        //calling the equation
        double[] equation = LineEquation(x1, y1, x2, y2);
        Console.WriteLine("Line Equation: y = " + equation[0] + "x + " + equation[1]);
    }
}
