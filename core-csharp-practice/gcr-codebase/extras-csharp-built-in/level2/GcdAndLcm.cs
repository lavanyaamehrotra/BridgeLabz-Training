// GCD and LCM Calculator:
// Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
// Multiple (LCM) of two numbers using functions.
// ● Use separate functions for GCD and LCM calculations, showcasing how modular code
// works.
using System;
class GcdAndLcm{
  static void Main(string[] args){
    // Get two numbers from the user
    int num1 = numberget("Enter the first number: ");
    int num2 = numberget("Enter the second number: ");
    // Calculate GCD
    int gcd = calculategcd(num1, num2);
    // Calculate LCM
    int lcm = calculatelcm(num1, num2, gcd);
    //  Display results
        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }
    // Function to get integer input from user
    static int numberget(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }
    // Function to calculate GCD 
    static int calculategcd(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

// Function to calculate LCM
    static int calculatelcm(int a, int b, int gcd){
        return (a * b) / gcd;
    }
}
