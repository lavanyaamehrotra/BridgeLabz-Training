//   Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
// Hint => 
// a.               Method to Check if a number is a prime number. A prime number is a number greater than 1 that has no positive divisors other than 1 and itself. 
// b.               Method to Check if a number is a neon number. A neon number is a number where the sum of digits of the square of the number is equal to the number itself 
// c.                Method to Check if a number is a spy number. A number is called a spy number if the sum of its digits is equal to the product of its digits
// d.               Method to Check if a number is an automorphic number. An automorphic number is a number whose square ends with the number itself. E.g. 5 is an automorphic number
// e.               Method to Check if a number is a buzz number. A buzz number is a number that is either divisible by 7 or ends with 7

using System;
class NumberCheckerFour{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Prime Number: " + IsPrime(number));
    Console.WriteLine("Neon Number: " + IsNeon(number));
    Console.WriteLine("Spy Number: " + IsSpy(number));
    Console.WriteLine("Automorphic Number: " + IsAutomorphic(number));
    Console.WriteLine("Buzz Number: " + IsBuzz(number));
  }
  // prime number
  static bool IsPrime(int n){
    if (n <= 1)
      return false;
    for (int i = 2; i <= n / 2; i++){
      if (n % i == 0)
        return false;
    }
    return true;
  }
  // NEON NUMBER 
    static bool IsNeon(int n){
        int square = n * n;
        int sum = 0;
        while (square > 0){
          sum += square % 10;
          square /= 10;
        }
      return sum == n;
    }

    // SPY NUMBER
    static bool IsSpy(int n){
        int sum = 0;
        int product = 1;

        while (n > 0){
            int digit = n % 10;
            sum += digit;
            product *= digit;
            n /= 10;
        }

        return sum == product;
    }

    // AUTOMORPHIC NUMBER 
    static bool IsAutomorphic(int n){
        int square = n * n;
        return square.ToString().EndsWith(n.ToString());
    }

    // BUZZ NUMBER 
    static bool IsBuzz(int n){
        return (n % 7 == 0) || (n % 10 == 7);
    }
}
