// Basic Calculator:
// Write a program that performs basic mathematical operations (addition, subtraction,
// multiplication, division) based on user input.
// ● Each operation should be performed in its own function, and the program should
// prompt the user to choose which operation to perform.
using System;
class BasicCalculator{
    // Addition
    static double Add(double a, double b){
        return a + b;
    }
    // Subtraction
    static double Subtract(double a, double b){
        return a - b;
    }

    // Multiplication
    static double Multiply(double a, double b){
        return a * b;
    }

    // Division
    static double Divide(double a, double b){
        return a / b;
    }

    static void Main(string[] args){
        Console.WriteLine("Addition");
        Console.WriteLine("Subtraction");
        Console.WriteLine("Multiplication");
        Console.WriteLine("Division");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double ans = 0;
        if (choice == "1"){
            ans = Add(number1, number2);
        }else if (choice == "2"){
            ans = Subtract(number1, number2);
        }else if (choice == "3"){
            ans = Multiply(number1, number2);
        }else if (choice == "4"){
            if (number2 == 0){
                Console.WriteLine("Not Valid");
                return;
            }
            ans = Divide(number1, number2);
        }else{
            Console.WriteLine("Not valid");
            return;
        }
        Console.WriteLine($"Result = {ans}");
    }
}
