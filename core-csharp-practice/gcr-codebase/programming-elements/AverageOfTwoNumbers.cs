using System;

namespace ProgrammingElements{
    class AverageOfTwoNumbers{
        static void Main(string[] args){
            // take the 1st input
            int a = int.Parse(Console.ReadLine());
            // take the 2nd input
            int b = int.Parse(Console.ReadLine());
            // take the 3rd input
            int c = int.Parse(Console.ReadLine());
            // calculate average
            double average = (a + b + c) / 3.0;
            Console.WriteLine("The average is: " + average);
        }
    }
}
