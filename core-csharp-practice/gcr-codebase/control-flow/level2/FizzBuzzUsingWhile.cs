//Rewrite the program 5 FizzBuzz using while loop 
using System;
class FizzBuzzUsingWhile{
  static void Main(string[] args){
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    if(number>0){
      int i=1;
      while(i<=number){
        if(i%3==0 && i%5==0){
          Console.WriteLine("FizzBuzz");
        }else if(i%3==0){
          Console.WriteLine("Fizz");
        }else if(i%5==0){
          Console.WriteLine("Buzz");
        }else{
          Console.WriteLine(i);
        }
        i++;
      }
    }
  }
}