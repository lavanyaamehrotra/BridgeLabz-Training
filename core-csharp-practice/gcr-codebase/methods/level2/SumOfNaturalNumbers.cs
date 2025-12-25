// Write a program to find the sum of n natural numbers using recursive method and compare the result with the formulae n*(n+1)/2 and show the result from both computations is correct. 
using System;
class SumOfNaturalNumbers{
  static void Main(){
    Console.Write("Enter a natural number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    // Check if input is a natural number 
      if (n <= 0){
        Console.WriteLine("Invalid input");
        return;
      }
      // Calculate sum using recursion
      int sumRec = SumRecursion(n);
      // Calculate sum using formula
      int sumForm = SumFormula(n);
      Console.WriteLine("Sum using recursion: " + sumRec);
      Console.WriteLine("Sum using formula: " + sumForm);
      // Compare results
      if (sumRec == sumForm){
        Console.WriteLine("Both methods give the same result!");
      }else{
        Console.WriteLine("Something went wrong, results are different!");
      }
    }
    // Method to calculate sum using recursion
    static int SumRecursion(int num){
      if (num == 1)
        return 1;
      else
        return num + SumRecursion(num - 1);
    }
    // Method to calculate sum using formula
    static int SumFormula(int num){
        return num * (num + 1) / 2;
    }
}
