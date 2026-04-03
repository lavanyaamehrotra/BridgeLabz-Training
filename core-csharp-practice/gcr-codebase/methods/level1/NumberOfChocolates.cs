// Create a program to divide N number of chocolates among M children. Print the number of chocolates each child will get and also the remaining chocolates
using System;
class NumberOfChocolates{
  static void Main(string[] args){
    Console.Write("Enter the numberOfChocolates");
    int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the numberOfChildren");
    int numberOfChildren=Convert.ToInt32(Console.ReadLine());
    int [] ans=CalculateNumberOfChocolates(numberOfChocolates, numberOfChildren );
    Console.WriteLine("The number of chocolates each child will get is : " + ans[0]);
    Console.WriteLine("Remaining chocolates: " + ans[1]);
  }
  static int[] CalculateNumberOfChocolates(int numberOfChocolates,int numberOfChildren){
    int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        return new int[] { chocolatesPerChild, remainingChocolates };
  }
}
