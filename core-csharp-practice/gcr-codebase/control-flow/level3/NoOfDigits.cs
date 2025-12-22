// Create a program to count the number of digits in an integer.
using System;
class NoOfDigits{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    int count=0;
    //iteration to count the number of digits
    while(number!=0){
      number/=10; // Remove the last digit from the number
      count++;    // Increase count by 1
    }
    Console.WriteLine("Number of digits are: " + count);
  }
}