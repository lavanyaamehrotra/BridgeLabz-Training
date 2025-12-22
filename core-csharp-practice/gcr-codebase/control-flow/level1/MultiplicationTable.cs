// Create a program to find the multiplication table of a number entered by the user from 6 to 9.__ 
using System;
class MultiplicationTable{
  static void Main(string [] args){
    Console.WriteLine("Enter an integer to print multiplication table from 6 to 9");
    int number=Convert.ToInt32(Console.ReadLine());
    //using for loop to find multiplication table
    for(int i=6;i<=9;i++){
      Console.WriteLine(number + " * " + i + " = " + (number*i));
    }
  }
}