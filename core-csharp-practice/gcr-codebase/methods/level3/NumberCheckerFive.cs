// Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
using System;

class NumberCheckerFive{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] factors = GetFactors(number);
    Console.WriteLine("\nFactors of " + number + ":");
    for (int i = 0; i < factors.Length; i++){
      Console.Write(factors[i] + " ");
    }
    Console.WriteLine("Greatest Factor = " + GetGreatestFactor(factors));
    Console.WriteLine("Sum of Factors = " + SumOfFactors(factors));
    Console.WriteLine("Product of Factors = " + ProductOfFactors(factors));
    Console.WriteLine("Product of Cubes of Factors = " + ProductOfCubes(factors));
    Console.WriteLine("\nPerfect Number = " + IsPerfect(number, factors));
    Console.WriteLine("Abundant Number = " + IsAbundant(number, factors));
    Console.WriteLine("Deficient Number = " + IsDeficient(number, factors));
    Console.WriteLine("Strong Number = " + IsStrong(number));
    Console.WriteLine();
    }
    // Get factors of number
    public static int[] GetFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }
        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // Greatest factor
    public static int GetGreatestFactor(int[] factors){
        int greatest = factors[0];

        for (int i = 1; i < factors.Length; i++){
            if (factors[i] > greatest)
                greatest = factors[i];
        }

        return greatest;
    }

    // Sum of factors
    public static int SumOfFactors(int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length; i++)
            sum += factors[i];

        return sum;
    }

    // Product of factors
    public static long ProductOfFactors(int[] factors){
        long product = 1;

        for (int i = 0; i < factors.Length; i++)
            product *= factors[i];

        return product;
    }

    // Product of cubes of factors
    public static double ProductOfCubes(int[] factors){
        double product = 1;

        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }

        return product;
    }
    // Perfect number check
    public static bool IsPerfect(int number, int[] factors){
            int sum = 0;

            for (int i = 0; i < factors.Length - 1; i++)
                sum += factors[i];

            return sum == number;
    }
    // Abundant number check
    public static bool IsAbundant(int number, int[] factors){
        int sum = 0;

        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];

        return sum > number;
    }
    // Deficient number check
    public static bool IsDeficient(int number, int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];

        return sum < number;
    }
     // Strong number check
    public static bool IsStrong(int number){
        int original = number;
        int sum = 0;
        while (number > 0){
            int digit = number % 10;
            sum += Factorial(digit);
            number /= 10;
        }
      return sum == original;
    }

    // Factorial helper
    public static int Factorial(int n){
        int fact = 1;

        for (int i = 1; i <= n; i++)
            fact *= i;

        return fact;
    }
}
