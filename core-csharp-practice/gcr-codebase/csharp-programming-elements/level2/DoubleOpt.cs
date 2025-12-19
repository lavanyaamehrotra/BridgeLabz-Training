// 3. Similarly, write the DoubleOpt program by taking double values and doing the same operations.
using System;
class DoubleOpt{
  static void Main(string[] args){
    Console.WriteLine("Enter first number: ");
    double a=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    double b=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter third number: ");
    double c=Convert.ToDouble(Console.ReadLine());
    //calculate a+b*c
    double operation1=a+b*c;
    //calculate a*b+c
    double operation2=a*b+c;
    //calculate c+a/b
    double operation3=c+a/b;
    //calculate a%b+c
    double operation4=a%b+c;
    Console.WriteLine("The results of Double Operations are: " + operation1 + ", " + operation2 + "," + operation3 + " and " + opeation4);
  }
}