using System;
class Utility{
  // Method to calculate factorial
  public static long Factorial(int n){
    //not valid for negative values
    if (n < 0){
      Console.WriteLine("Not valid for negative");
      return -1;
    }
    long fact = 1;
    for (int i = 2; i <= n; i++){
      fact *= i;
    }
    return fact;
  }
  // Method to check for prime number
  public static bool IsPrime(int n){
    if (n <= 1){
      return false;
    }
    for (int i = 2; i <= Math.Sqrt(n); i++){
      if (n % i == 0){
        return false;
      }
    }
    return true;
  }
  // Method to find gcd of two numbers
  public static int GCD(int a, int b){
    while (b != 0){
      int temp = b;
      b = a % b;
      a = temp;
    }
    return Math.Abs(a);
  }
  // Method to find nth Fibonacci number
  public static long Fibonacci(int n){
    if (n < 0){
      Console.WriteLine("Fibonacci number is not for negative number");
      return -1;
    }
    if (n == 0){
      return 0;
    }
    if (n == 1){
      return 1;
    }
    long a = 0, b = 1, c = 0;
    for (int i = 2; i <= n; i++){
      c = a + b;
      a = b;
      b = c;
    }
    return c;
  }
  static void Main(string[] args){
    int option;
    do{
      Console.WriteLine("\n======= Math Utility Menu ========");
      Console.WriteLine("1. Factorial");
      Console.WriteLine("2. Check Prime");
      Console.WriteLine("3. GCD of Two Numbers");
      Console.WriteLine("4. nth Fibonacci Number");
      Console.WriteLine("5. Exit");
      Console.Write("Enter your option: ");
      option = Convert.ToInt32(Console.ReadLine());
      switch (option){
        case 1:
          Console.Write("Enter a number: ");
          int number = Convert.ToInt32(Console.ReadLine());
          long fact =Factorial(number);
          if (fact != -1){
            Console.WriteLine($"Factorial of {number} is {fact}");
          }
          break;
          case 2:
          Console.Write("Enter a number: ");
          int primeNumber = Convert.ToInt32(Console.ReadLine());
          bool isPrime = IsPrime(primeNumber);
          Console.WriteLine(isPrime ? $"{primeNumber} is Prime" : $"{primeNumber} is Not Prime");
          break;
          case 3:
          Console.Write("Enter first number: ");
          int a = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter second number: ");
          int b = Convert.ToInt32(Console.ReadLine());
          int gcd = GCD(a, b);
          Console.WriteLine($"GCD of {a} and {b} is {gcd}");
          break;
          case 4:
          Console.Write("Enter n: ");
          int n = Convert.ToInt32(Console.ReadLine());
          long fibonacciNumber = Fibonacci(n);
          if (fibonacciNumber != -1){
          Console.WriteLine($"{n}th Fibonacci number is {fibonacciNumber}");
          }
          break;
          case 5:
          Console.WriteLine("Thanku for using");
          break;
          default:
          Console.WriteLine("Invalid option");
          break;
        }
    } while (option != 5);
  }
}
