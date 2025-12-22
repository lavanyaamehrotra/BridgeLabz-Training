// Create a program to check if a number taken from the user is a Harshad Number.
using System;
class HarshadNumber{  
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    int originalNumber = number; // Store the original number for later use
    int sum=0;
    //iteration to calculate the sum of digits
    while(number!=0){
      sum += number % 10; // Add the last digit to sum
      number /= 10;       // Remove the last digit from the number
    }
    // Check if the original number is divisible by the sum of its digits
    if(originalNumber % sum == 0){
      Console.WriteLine(originalNumber + " is a Harshad Number");
    }else{
      Console.WriteLine(originalNumber + " is Not a Harshad Number");
    }
  }
}