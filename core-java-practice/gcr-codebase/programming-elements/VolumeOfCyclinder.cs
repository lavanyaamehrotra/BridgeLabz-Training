using System;

namespace ProgrammingElements{
    class VolumeOfCylinder{
        static void Main(string[] args){
            // write a program to calculate the volume of a cylinder
            // Formula: π × r² × h
            double radius = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = Math.PI * radius * radius * height;
            Console.WriteLine("Volume of the cylinder is: " + volume);
        }
    }
}
