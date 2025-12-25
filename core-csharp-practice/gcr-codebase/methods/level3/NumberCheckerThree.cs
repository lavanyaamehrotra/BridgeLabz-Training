//Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
using System;
class NumberChecker{
  static void Main(){
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // count digits + store digits
    int count = CountDigits(number);
    int[] digits = StoreDigits(number, count);
    Console.WriteLine("\nDigits:");
    for(int i = 0; i < digits.Length; i++)
      Console.Write(digits[i] + " ");
    // reverse digits array
    int[] reversed = ReverseArray(digits);
    Console.WriteLine("\n\nReversed Digits:");
    for(int i = 0; i < reversed.Length; i++)
      Console.Write(reversed[i] + " ");
    // compare arrays
    bool equal = ArraysEqual(digits, reversed);
    Console.WriteLine("Arrays Equal? " + equal);
    //check palindrome
    bool isPalindrome = IsPalindrome(digits, reversed);
    Console.WriteLine("Palindrome Number" + isPalindrome);
    //check duck number
    bool isDuck = IsDuckNumber(digits);
    Console.WriteLine("Duck Number? " + isDuck);
  }
//counting digits
    public static int CountDigits(int num){
        int count = 0;
        int temp = num;
        while (temp > 0){
            count++;
            temp /= 10;
        }
        return count;
    }

    //storing digits in array
    public static int[] StoreDigits(int num, int size){
        int[] digits = new int[size];
        int temp = num;

        for (int i = size - 1; i >= 0; i--){
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    //reverse array
    public static int[] ReverseArray(int[] arr){
        int[] rev = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++){
            rev[i] = arr[arr.Length - 1 - i];
        }
        return rev;
    }

    //comparing two arrays
    public static bool ArraysEqual(int[] a, int[] b){
        if (a.Length != b.Length)
            return false;
        for (int i = 0; i < a.Length; i++){
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
    //palindrome check 
    public static bool IsPalindrome(int[] digits, int[] reversed){
        return ArraysEqual(digits, reversed);
    }
    //duck number check 
    public static bool IsDuckNumber(int[] digits){
        if (digits[0] == 0)
            return false;
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] == 0)
                return true;
        }
        return false;
    }
}
