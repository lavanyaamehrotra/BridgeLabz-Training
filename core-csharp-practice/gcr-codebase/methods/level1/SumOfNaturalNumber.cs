// Write a program to find the sum of n natural numbers using loop
using System;
class SumOfNaturalNumber{
  static void Main(string[] args){
    Console.WriteLine("Enter the number: ");
    int number=Convert.ToInt32(Console.ReadLine());
    int sum=CalculateSum(number);
    Console.WriteLine("The sum of first " + number + " natural numbers is: " + sum);
  }
  //method to calculate sum of n natural numbers
  static int CalculateSum(int n){
    int sum=0;
    for(int i=1;i<=n;i++){
      sum+=i;
    }
    return sum;
  }
}