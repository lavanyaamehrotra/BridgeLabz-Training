// Write a program to take 2 numbers and print their quotient and reminder
using System;
class QuotientAndRemainder{
  static void Main(string[] args){
    Console.Write("Enter the dividend: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
  }
  public static int[] FindRemainderAndQuotient(int number, int divisor){
      //calculating the quotient and the remainder
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
  }
}
