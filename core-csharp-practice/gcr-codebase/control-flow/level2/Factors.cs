// .Create a program to find the factors of a number taken as user input.
using System;
class Factors{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Factors of " + number + " are:");
    //iteration to find factors
    for(int i=1;i<=number;i++){
      if(number%i==0){
        Console.WriteLine(i);
      }
    }
  }
}