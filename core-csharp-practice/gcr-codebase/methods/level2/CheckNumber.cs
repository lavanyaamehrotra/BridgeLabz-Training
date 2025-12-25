//  Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less
using System;
class CheckNumber{  
static void Main(){
  int[] numbers = new int[5];
  for (int i = 0; i < numbers.Length; i++){
    Console.Write("Enter number " + (i + 1) + ": ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
  for (int i = 0; i < numbers.Length; i++){
    if (IsPositive(numbers[i])){
      Console.Write(numbers[i] + " is positive and ");
      if (IsEven(numbers[i]))
        Console.WriteLine("even.");
      else
        Console.WriteLine("odd.");
    }else{
      Console.WriteLine(numbers[i] + " is negative.");
    }
  }
  // Compare first and last elements
  int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);
  Console.WriteLine("Comparing first and last numbers:");
  if (comparison == 1){
    Console.WriteLine(numbers[0] + " is greater than " + numbers[numbers.Length - 1]);
  }else if (comparison == 0){
    Console.WriteLine(numbers[0] + " is equal to " + numbers[numbers.Length - 1]);
  }else{
    Console.WriteLine(numbers[0] + " is less than " + numbers[numbers.Length - 1]);
  }
}
// Method to check if a number is positive or negative
  public static bool IsPositive(int number){
    return number >= 0;
  }
  // Method to check if a number is even or odd
  public static bool IsEven(int number){
    return number % 2 == 0;
  }

  // Method to compare two numbers
  public static int Compare(int number1, int number2){
    if (number1 > number2) return 1;
    else if (number1 == number2) return 0;
    else return -1;
  }
}
