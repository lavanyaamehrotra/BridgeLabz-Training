//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
using System;
class NumberChecker{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int digitCount = CountDigits(number);
    int[] digits = StoreDigits(number, digitCount);
    Console.WriteLine("Digits in number:");
    for (int i = 0; i < digits.Length; i++)
    Console.Write(digits[i] + " ");
    Console.WriteLine("Total Digits = " + digitCount);
    // Duck number
    if (IsDuckNumber(digits)){
      Console.WriteLine("Duck Number: YES");
    }else{
      Console.WriteLine("Duck Number: NO");
    }
    // Armstrong number
    if (IsArmstrong(number, digits)){
      Console.WriteLine("Armstrong Number: YES");
    }else{
      Console.WriteLine("Armstrong Number: NO");
    }
    // Largest & 2nd Largest
    int largest = FindLargest(digits);
    int secondLargest = FindSecondLargest(digits, largest);
    // Smallest & 2nd Smallest
    int smallest = FindSmallest(digits);
    int secondSmallest = FindSecondSmallest(digits, smallest);
    Console.WriteLine("Largest = " + largest);
    Console.WriteLine("Second Largest = " + secondLargest);
    Console.WriteLine("Smallest = " + smallest);
    Console.WriteLine("Second Smallest = " + secondSmallest);
  }
  public static int CountDigits(int num){
    int count = 0;
    int temp = num;
    while (temp > 0){
      count++;
      temp /= 10;
    }
    return count;
  }
  public static int[] StoreDigits(int num, int size){
    int[] digits = new int[size];
    int index = size - 1;
    int temp = num;
    while (temp > 0){
      digits[index] = temp % 10;
      temp /= 10;
      index--;
    }
    return digits;
  }
  public static bool IsDuckNumber(int[] digits){
    for (int i = 0; i < digits.Length; i++){
      if (digits[i] == 0){
        return true;
      }
    }
    return false;
  }
  public static bool IsArmstrong(int number, int[] digits){
    int sum = 0;
    int power = digits.Length;
    for (int i = 0; i < digits.Length; i++){
      sum += (int)Math.Pow(digits[i], power);
    }
    return sum == number;
  }

    public static int FindLargest(int[] digits){
        int largest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] > largest)
                largest = digits[i];
        }
        return largest;
    }
public static int FindSecondLargest(int[] digits, int largest){
        int second = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != largest && digits[i] > second)
                second = digits[i];
        }
        return second;
    }
public static int FindSmallest(int[] digits){
        int smallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < smallest)
                smallest = digits[i];
        }
        return smallest;
    }
    public static int FindSecondSmallest(int[] digits, int smallest){
        int second = Int32.MaxValue;
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != smallest && digits[i] < second)
                second = digits[i];
        }
      return second;
    }
}
