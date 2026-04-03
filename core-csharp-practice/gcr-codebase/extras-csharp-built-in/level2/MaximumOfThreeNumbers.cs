// Maximum of Three Numbers:
// Write a program that takes three integer inputs from the user and finds the maximum of the
// three numbers.
// ● Ensure your program follows best practices for organizing code into modular
// functions, such as separate functions for taking input and calculating the maximum
// value.
using System;
class MaximumOfThreeNumbers{
  static void Main(string[] args){
    int num1 = getinput("Enter first number: ");
    int num2 = getinput("Enter second number: ");
    int num3 = getinput("Enter third number: ");
    // Calculate maximum
    int maximum = FindMaximum(num1, num2, num3);
    Console.WriteLine($"The maximum number is: {maximum}");
  }
  static int getinput(string mssg){
    Console.Write(mssg);
    return Convert.ToInt32(Console.ReadLine());
  }
  // Method to find maximum of three numbers
  static int FindMaximum(int a, int b, int c){
    int maximum = a;
    if (b > maximum){
      maximum = b;
    }if (c > maximum){
      maximum = c;
    }
    return maximum;
  }
}
