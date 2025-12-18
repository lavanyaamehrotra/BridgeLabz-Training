using System;
namespace ProgrammingElements{
    class AreaOfCircle{
        static void Main(string[] args){
            // write a program to calculate the area of a circle
            // take radius value as input
            int radius = int.Parse(Console.ReadLine());
            // take pi as value
            double pi = 3.14;
            // calculate the area
            double area = pi * radius * radius;
            Console.WriteLine("Area of the circle is: " + area);
        }
    }
}
