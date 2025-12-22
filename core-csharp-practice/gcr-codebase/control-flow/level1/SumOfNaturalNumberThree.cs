// Rewrite the program number 12 with the for loop instead of a while loop to find the sum of n Natural Numbers. 
using System;
class SumOfNaturalNumberThree{
  static void Main(string [] args){
    Console.WriteLine("Enter a natural number");
    int number=Convert.ToInt32(Console.ReadLine());
    //checking whether the number is natural number
    if(number>0){
      int sum=0;
      //calculating sum using for loop
      for(int i=1;i<=number;i++){
        sum+=i;
      }
      //calculating sum using formula
      int formulaSum=number*(number+1)/2;
      //comparing both sums
      if(sum==formulaSum){
        Console.WriteLine("The sum using for loop is: " + sum);
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