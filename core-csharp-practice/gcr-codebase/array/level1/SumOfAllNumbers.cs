// Write a program to store multiple values in an array up to a maximum of 10 or until the user enters a 0 or a negative number. Show all the numbers as well as the sum of all numbers 
using System;
class SumOfAllNumbers{
  static void Main(string[] args){
    double[] numbers=new double[10];
    double total=0.0;
    int index=0;
    while(true){
      Console.WriteLine("Enter a number:");
      double input=Convert.ToDouble(Console.ReadLine());
      if(input<=0){
        break;
      }
      if(index==10){
        break;
      }
      numbers[index]=input;
      index++;
    }
    for(int i=0;i<index;i++){
      total+=numbers[i];
    }
    Console.WriteLine("The sum of all numbers is: " + total);
  }
}
  