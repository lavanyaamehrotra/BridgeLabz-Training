//Use all the operators in c#
using System;
class Operators{
  static void Main(string[] args){
    int a=5;
    int b=5;

    //Arithmetic Operators
    Console.WriteLine("Arithmetic Operators:");
    Console.WriteLine("Addition: " + (a + b));
    Console.WriteLine("Subtraction: " + (a - b));
    Console.WriteLine("Multiplication: " + (a * b));
    Console.WriteLine("Division: " + (a / b));
    Console.WriteLine("Modulus: " + (a % b));

    //Comparison Operators
    Console.WriteLine("Comparison Operators:");
    Console.WriteLine("Equal to: " + (a == b));
    Console.WriteLine("Not equal to: " + (a != b));
    Console.WriteLine("Greater than: " + (a > b));
    Console.WriteLine("Less than: " + (a < b));
    Console.WriteLine("Greater than or equal to: " + (a >= b));
    Console.WriteLine("Less than or equal to: " + (a <= b));
    
    //Logical Operators
    Console.WriteLine("Logical Operators:");
    Console.WriteLine("Logical AND: " + (a > 0 && b > 0));
    Console.WriteLine("Logical OR: " + (a > 0 || b < 0));
    Console.WriteLine("Logical NOT: " + !(a > 0));
    
    //Assignment Operators
    Console.WriteLine("Assignment Operators:");
    int c = a; 
    Console.WriteLine("Simple Assignment: " + c);
    c += b; // Addition 
    Console.WriteLine("Addition Assignment: " + c);
    c -= b; // Subtraction 
    Console.WriteLine("Subtraction Assignment: " + c);
    c *= b; // Multiplication 
    Console.WriteLine("Multiplication Assignment: " + c);
    c /= b; // Division 
    Console.WriteLine("Division Assignment: " + c);
    c %= b; // Modulus 
    Console.WriteLine("Modulus Assignment: " + c);
    
    //Increment and Decrement Operators
    Console.WriteLine("Increment and Decrement Operators:");
    Console.WriteLine("Initial value of a: " + a);
    Console.WriteLine("Post-increment a: " + (a++));
    Console.WriteLine("Value after postincrement: " + a);
    Console.WriteLine("Pre-increment a: " + (++a));
    Console.WriteLine("Value after preincrement: " + a);
    Console.WriteLine("Post-decrement a: " + (a--));
    Console.WriteLine("Value after postdecrement: " + a);
    Console.WriteLine("Pre-decrement a: " + (--a));
    Console.WriteLine("Value after predecrement: " + a);
  }
}