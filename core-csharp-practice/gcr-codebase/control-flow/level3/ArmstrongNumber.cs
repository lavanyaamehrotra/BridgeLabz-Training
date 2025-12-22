// Create a program to check if a number is Armstrong or not. Use the hints to show the steps clearly in the code
using System;
class ArmstrongNumber{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    int sum=0;
    int originalNumber=number;
    while(originalNumber!=0){
      int remainder=originalNumber%10;//extract the last digit of the number
      sum+=remainder*remainder*remainder;  // Add the cube of the digit to sum
      originalNumber/=10;// Remove the last digit from the number
    }
    if(sum==number){
      Console.WriteLine(number + " is an Armstrong number");
    }else{
      Console.WriteLine(number + " is not an Armstrong number");
    }
  }
}