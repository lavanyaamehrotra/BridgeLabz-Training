// 11. Write a program to create a basic calculator that can perform addition, subtraction, multiplication, and division. The program should ask for two numbers (floating point) and perform all the operations
// Hint:
// Create a variable number1 and number 2 and take user inputs.
// Perform Arithmetic Operations of addition, subtraction, multiplication, and division and assign the result to a variable and finally print the result
// I/P => number1, number2
// O/P => The addition, subtraction, multiplication and division value of 2 numbers ___ and ___ is ___, ____, ____, and ___
using System;
class AdditionSubtractionMultiplicationDivision{
    public static void Main(string[] args){
      Console.WriteLine("Enter first number:");
      double n1=Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter second number:");
      double n2=Convert.ToDouble(Console.ReadLine());
      //addition
      double addition=n1+n2;
      //subtraction
      double subtraction=n1-n2;
      //multiplication
      double multiplication=n1*n2;
      //division
      double division=n1/n2;
      Console.WriteLine("The addition,subtraction,multiplication and division value of 2 numbers is:"+ addition +"," +subtra)
    }
}