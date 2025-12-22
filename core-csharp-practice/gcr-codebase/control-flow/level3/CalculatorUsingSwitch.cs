// Write a program to create a calculator using switch...case.
using System;
class CalculatorUsingSwitch{
  static void Main(string[] args){
    Console.WriteLine("Enter first number:");
    double first=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    double second=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter an operator (+, -, *, /):");
    string op=Console.ReadLine();
    double result=0;
    switch(op){
      case "+":
        result=first+second;
        Console.WriteLine("Result: " + result);
        break;
      case "-":
        result=first-second;
        Console.WriteLine("Result: " + result);
        break;
      case "*":
        result=first*second;
        Console.WriteLine("Result: " + result);
        break;
      case "/":
        if(second!=0){
          result=first/second;
          Console.WriteLine("Result: " + result);
        }else{
          Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
      default:
        Console.WriteLine("Invalid Operator");
        break;
    }
  }
}
