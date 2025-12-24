// Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
using System;
class ReverseTheNumber{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to reverse:");
    int number = Convert.ToInt32(Console.ReadLine());
    int maxDigit = 10;
    int[] digits = new int[maxDigit];
    int index = 0;
    // extracting digits and store in array
    while (number != 0){
      if (index == maxDigit){
        maxDigit += 10;
        int[] temp = new int[maxDigit];
        for (int i = 0; i < digits.Length; i++)
        temp[i] = digits[i];
        digits = temp;
      }
      // get last digit
      digits[index] = number % 10;
      number /= 10;
      index++;
    }
    Console.WriteLine("The reversed number is:");
    for (int i = 0; i < index; i++){
      Console.Write(digits[i]);
    }
    Console.WriteLine();
  }
}
