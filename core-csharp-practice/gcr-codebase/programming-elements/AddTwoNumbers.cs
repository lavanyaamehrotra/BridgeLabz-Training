using System;

namespace ProgrammingElements{
    // Write a program that takes two numbers as input from user and prints their sum
    class AddTwoNumbers{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sum = n + m;
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
