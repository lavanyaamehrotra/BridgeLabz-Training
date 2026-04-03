// Write a program to find the smallest and the largest of the 3 numbers.
using System;
class SmallestAndLargestNumber{
  static void Main(string[] args){
    Console.WriteLine("Enter first number: ");
    int number1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int number2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third number: ");
    int number3=Convert.ToInt32(Console.ReadLine());
    int[] result=FindSmallestAndLargest(number1,number2,number3);
    //displaying smallest and largest number
    Console.WriteLine("The smallest number is: " + result[0]);
    Console.WriteLine("The largest number is: " + result[1]);
  }
  public static int[] FindSmallestAndLargest(int number1, int number2, int number3){
   //finding smallest and largest number
    int smallest=number1;
    int largest=number1;
    if(number2<smallest){
      smallest=number2;
    }
    if(number3<smallest){
      smallest=number3;
    }
    if(number2>largest){
      largest=number2;
    }
    if(number3>largest){
      largest=number3;
    }
    //returning smallest and largest number
    return new int[]{smallest, largest};
  }
}