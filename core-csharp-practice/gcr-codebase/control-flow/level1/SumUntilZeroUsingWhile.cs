// Rewrite the program 10 to find the sum until the user enters 0 or a negative number using while loop and break statement
using System;
class SumUntilZeroUsingWhile{
  static void Main(string [] args){
    double total=0.0;
    double number;
    Console.WriteLine("Enter a number");
    number=Convert.ToDouble(Console.ReadLine());
    //calculating sum until user enter 0 or negative number
    while(true){
      if(number<=0){
        break;
      }
      total+=number;
      Console.WriteLine("Enter a number");
      number=Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("The total sum is:" + total);
  }
}