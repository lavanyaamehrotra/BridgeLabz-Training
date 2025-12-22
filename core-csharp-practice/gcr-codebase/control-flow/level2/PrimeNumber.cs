// Write a Program to check if the given number is a prime number or not
using System;
class PrimeNumber{
  static void Main(string [] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    bool isPrime=true;
    if(number<=1){
      isPrime=false;
    }//iteration for checking its divisibility
    else{
      for(int i=2;i<=Math.Sqrt(number);i++){
        if(number%i==0){
          isPrime=false;
          break;
        }
      }
    }
    if(isPrime){
      Console.WriteLine(number + "is a Prime Number");
    }else{
      Console.WriteLine(number + "is not a Prime Number");
    }
  }
}

