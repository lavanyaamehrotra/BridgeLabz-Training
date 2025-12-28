// Fibonacci Sequence Generator:
// Write a program that generates the Fibonacci sequence up to a specified number of terms
// entered by the user.
// ● Organize the code by creating a function that calculates and prints the Fibonacci
// sequence.
using System;
class FibonacciSequence{
  static void Main(string[] args){
  Console.Write("Enter the number of terms ");
  int n = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine($"Fibonacci sequence up to {n} terms:");
  PrintFibonacci(n);
  }
  // Function to calculate and print Fibonacci sequence
  static void PrintFibonacci(int terms){
    int a = 0, b = 1;
    for (int i = 1; i <= terms; i++){
      Console.Write(a + " ");
      int temp = a + b;
      a = b;
      b = temp;
    }
    Console.WriteLine();
  }
}
