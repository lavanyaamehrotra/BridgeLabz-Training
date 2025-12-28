// Prime Number Checker:
// Create a program that checks whether a given number is a prime number.
// ● The program should use a separate function to perform the prime check and return
// the result.
using System;
class PrimeNumber{
  static void Main(){
    Console.Write("Enter a number  ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (IsPrime(number)){
      Console.WriteLine($"{number} is a prime number.");
    }else{
      Console.WriteLine($"{number} is not a prime number.");
    }
  }
  // Function to check if a number is prime
  static bool IsPrime(int n){
    if (n <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++){
      if (n % i == 0)
        return false;
    }
    return true;
  }
}
