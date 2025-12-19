// 2. Write an IntOperation program by taking a, b, and c as input values and print the following integer operations: a + b * c, a * b + c, c + a / b, and a % b + c. Please also understand the precedence of the operators.
using System;
class IntOperationProgram{
  static void Main(string[] args){
    Console.WriteLine("Enter first number: ");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    int b=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter third number: ");
    int c=Convert.ToInt32(Console.ReadLine());
    //Calculating a+b*c
    int operation1=a+b*c;
    //calculatin a*b+c
    int operation2=a*b+c;
    //calculating c+a/b
    int operation3=c+a/b;
    //calculating a%b+c
    int operation4=a%b+c;
    Console.WriteLine("The results of Int Operations are: " + operation1 + ", " + operation2 + "," +operation3 +"and "+ operation4);
  }
}