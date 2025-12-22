// Write a program to find the sum of n natural numbers using while loop compare the result with the formulae n*(n+1)/2 and show the result from both computations was correct. 
using System;
class SumOfNaturalNumbersTwo{
  static void Main(string [] args){
    Console.WriteLine("Enter a natural number");
    int number=Convert.ToInt32(Console.ReadLine());
    //check whether the number is natural number
    if(number>0){
      int sum=0;
      int i=1;
      //calculating sum using while loop
      while(i<=number){
        sum+=i;
        i++;
      }
      //calculating sum using formula
      int formulaSum=number*(number+1)/2;
      //comparing both sums
      if(sum==formulaSum){
        Console.WriteLine("The sum using while loop is: " + sum);
        Console.WriteLine("The sum using formula is: " + formulaSum);
        Console.WriteLine("Both are correct.");
      }else{
        Console.WriteLine("There is a change in computations.");
      }
    }else{
      Console.WriteLine("Please enter a valid natural number.");
    }
  }
}