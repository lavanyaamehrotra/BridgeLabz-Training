//Use all the data types in c# and also do the type conversion.
using System;
namespace ProgrammingElements{
    class DataType{
      static void Main(string[] args){
        //Integer
        int a=10;
        Console.WriteLine("Integer: " + a);
        //Float
        foat b=10.5f;
        Console.WriteLine("Float: " + b);
        //Double
        double c=20.99;
        Console.WriteLine("Double: " + c);
        //Character
        char d='A';
        Console.WriteLine("Character: " + d);
        //String
        string e="My Name is Lavanya Mehrotra";
        Console.WriteLine("String: " + e);
        //Boolean
        bool f=true;
        Console.WriteLine("Boolean: " + f);
        //Byte
        byte g=100;
        Console.WriteLine("Byte: " + g);
        //Short
        short h=1000;
        Console.WriteLine("Short: " + h);
        //Long
        Long i=10000000000;
        Console.WriteLine("Long: " + i);

        //-----------------------------------------------------------
        //Type Conversion
        //Implicit Conversion
        int j=100;
        //int to double
        double k=j;
        Console.WriteLine("Implicit Conversion from int to double: " + k);

        //Explicit Conversion
        double l=8.39;
        //double to int
        int m=(int)l;
        Console.WriteLine("Explicit Conversion from double to int: " + m);

      //.0 doest not come because of console.WriteLine taught in the class.
      }
    }
}