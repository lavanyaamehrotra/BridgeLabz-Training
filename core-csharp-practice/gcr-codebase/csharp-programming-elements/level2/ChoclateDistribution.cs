// 10. Create a program to divide N number of chocolates among M children.
using System;
class ChoclateDistribution{
  static void Main(string[] args){
    Console.WriteLine("Enter the number of chocolates:");
    int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of children:");
    int numberOfChildren=Convert.ToInt32(Console.ReadLine());
    //Formula to calculate chocolates each child gets
    int chocolatesPerChild=numberOfChocolates/numberOfChildren;
    //Formula to calculate remaining chocolates
    int remainingChocolates=numberOfChocolates%numberOfChildren;
    Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates);
  }
}