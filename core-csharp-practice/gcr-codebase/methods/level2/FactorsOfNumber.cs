//.Create a program to find the factors of a number taken as user input, store the factors in an array and display the factors. Also find the sum, sum of square of factors and product of the factors and display the results
using System;
class FactorsOfNumber{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // Find factors
    int[] factors = FindFactors(number);
    Console.Write("Factors: ");
    foreach (int factor in factors){
      Console.Write(factor + " ");
    }
    Console.WriteLine();
    // Calculate sum, product, sum of squares
    int sum = SumOfFactors(factors);
    int product = ProductOfFactors(factors);
    double sumOfSquares = SumOfSquares(factors);
    // Display results
    Console.WriteLine("Sum of factors: " + sum);
    Console.WriteLine("Product of factors: " + product);
    Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
  }
  // Method to find factors and store them in an array
  public static int[] FindFactors(int number){
  int count = 0;
  // First loop: count the number of factors
  for (int i = 1; i <= number; i++){
    if (number % i == 0)
      count++;
  }
  // Initialize array with factor count
  int[] factors = new int[count];
  int index = 0;
  // Second loop: store the factors
  for (int i = 1; i <= number; i++){
    if (number % i == 0){
      factors[index] = i;
      index++;
    }
  }
  return factors;
  }
  // Method to find sum of factors
  public static int SumOfFactors(int[] factors){
  int sum = 0;
  foreach (int factor in factors){
    sum += factor;
  }
  return sum;
  }
  // Method to find product of factors
    public static int ProductOfFactors(int[] factors){
        int product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }
    // Method to find sum of squares of factors
    public static double SumOfSquares(int[] factors){
        double sumSquares = 0;
        foreach (int factor in factors){
            sumSquares += Math.Pow(factor, 2);
        }
        return sumSquares;
    }
}
