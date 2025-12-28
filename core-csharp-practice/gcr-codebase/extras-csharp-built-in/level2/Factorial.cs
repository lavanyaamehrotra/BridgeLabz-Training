// 6. Factorial Using Recursion:
// Write a program that calculates the factorial of a number using a recursive function.
// ● Include modular code to separate input, calculation, and output processes.
using System;
class Factorial{
  static void Main(string[] args){
      int number = getNumber();
    // Calculate the factorial
      long ans = calculateFactorial(number);
    // Show the ans
      displayAns(number, ans);
  }
  // Function to get user input
  static int getNumber(){
    Console.Write("Please enter non-negative integer: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
  }
  // function to calculate factorial
    static long calculateFactorial(int n){
      if (n == 0 || n == 1){
        return 1;
      }else{
        return n * calculateFactorial(n - 1);
      }
    }
    // Function to display the ans
  static void displayAns(int number, long factorial){
    Console.WriteLine($"The factorial of {number} is {factorial}");
  }
}
