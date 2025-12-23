// Create a program to print a multiplication table of a number.
using System;
class MultiplicationTable{
  static void Main(string[] args){
    Console.WriteLine("Enter a number to print its multiplication table:");
    int number=Convert.ToInt32(Console.ReadLine());
    int[] multiplicationTable=new int[10];
    for(int i=1;i<=10;i++){
      multiplicationTable[i-1]=number*i;
    }
    Console.WriteLine("Multiplication Table of " + number + ":");
    for(int i=1;i<=10;i++){
      Console.WriteLine(number + " * " + i + " = " + multiplicationTable[i-1]);
    }
  }
}