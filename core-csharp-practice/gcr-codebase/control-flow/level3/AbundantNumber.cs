// Create a program to check if a number is an Abundant Number.
using System;
class AbundantNumber{  
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    int sum=0;
    //iteration to calculate the sum of divisors
    for(int i=1;i<number;i++){
      if(number%i==0){
        sum += i; // Add the divisor to sum
      }
    }
    // Check if the sum of divisors is greater than the number
    if(sum > number){
      Console.WriteLine(number + " is an Abundant Number");
    }else{
      Console.WriteLine(number + " is Not an Abundant Number");
    }
  }
}