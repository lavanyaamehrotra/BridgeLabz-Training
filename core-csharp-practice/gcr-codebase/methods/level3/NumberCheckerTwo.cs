// Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
using System;
class NumberChecker{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    //Count digits and store digits
    int digitCount = CountDigits(number);
    int[] digits = StoreDigits(number, digitCount);
    Console.WriteLine("Digits in number:");
    for (int i = 0; i < digits.Length; i++)
      Console.Write(digits[i] + " ");
    Console.WriteLine("\nDigit Count = " + digitCount);
    //Sum of digits
    int sumDigits = SumDigits(digits);
    Console.WriteLine("Sum of Digits = " + sumDigits);
    //Sum of squares of digits
    int sumSquares = SumSquaresOfDigits(digits);
    Console.WriteLine("Sum of Squares of Digits = " + sumSquares);
    //Check Harshad number
    if (Harshad(number, sumDigits))
      Console.WriteLine("Harshad Number: YES");
    else
      Console.WriteLine("Harshad Number: NO");
    //Digit frequency
    int[,] frequency = DigitFrequency(digits);
    Console.WriteLine("\nDigit Frequency:");
    for (int i = 0; i < 10; i++){
      if (frequency[i, 1] > 0)
        Console.WriteLine("Digit " + frequency[i, 0] + " = " + frequency[i, 1]);
    }
  }
  // Count digits
  public static int CountDigits(int num){
    int count = 0;
    int temp = num;
    while (temp > 0){
      count++;
      temp /= 10;
    }
    return count;
  }

  //Store digits in array
  public static int[] StoreDigits(int num, int size){
    int[] digits = new int[size];
    int temp = num;
    for (int i = size - 1; i >= 0; i--){
      digits[i] = temp % 10;
      temp /= 10;
    }
    return digits;
  }

  //Sum of digits
  public static int SumDigits(int[] digits){
    int sum = 0;
    for (int i = 0; i < digits.Length; i++)
      sum += digits[i];
    return sum;
  }
  //Sum of squares of digits
  public static int SumSquaresOfDigits(int[] digits){
    int sum = 0;
    for (int i = 0; i < digits.Length; i++)
      sum += (int)Math.Pow(digits[i], 2);
    return sum;
  }

  //Harshad number check
  public static bool Harshad(int number, int sumDigits){
    return number % sumDigits == 0;
  }

  //Digit frequency in 2D array
  public static int[,] DigitFrequency(int[] digits){
    int[,] freq = new int[10, 2];
    for (int i = 0; i < 10; i++)
      freq[i, 0] = i;
    for (int i = 0; i < digits.Length; i++)
      freq[digits[i], 1]++;
    return freq;
  }
}
