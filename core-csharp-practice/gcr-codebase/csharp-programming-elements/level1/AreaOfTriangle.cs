// 12. Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters
using System;
class AreaOfTriangle{
  static void Main(string[] args){
    Console.WriteLine("Enter the base of a Triangle:");
    double base=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the height of a Triangle:");
    double height=Convert.ToDouble(Console.ReadLine());
    //Formula to calculate Area Of Triangle
    double area=0.5*base*height;
    Console.WriteLine("The area of the Triangle is: " + area);
  }
}