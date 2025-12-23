// Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result
using System;
class MultiplicationTableOfSixToNine{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to printmultiplication table from 6 to 9:");
    int number=Convert.ToInt32(Console.ReadLine());
    int[] Result=new int[4];
    for(int i=6;i<=9;i++){
      Result[i-6]=number*i;
    }
    Console.WriteLine("Multiplication Table of " + number + " from 6 to 9:");
    for(int i=6;i<=9;i++){
      Console.WriteLine(number + " * " + i + " = " + Result[i-6]);
    }
  }
}