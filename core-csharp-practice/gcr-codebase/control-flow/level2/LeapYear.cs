// Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year.
using System;
class LeapYear{
  static void Main(string[] args){
    Console.WriteLine("Enter a year");
    int year=Convert.ToInt32(Console.ReadLine());
    //checking if the year is greater than or equal to 1582
    if(year>=1582){
      //checking if the year is a leap year or not using multiple if-else statements
      if(year%4==0){
        if(year%100==0){
          if(year%400==0){
            Console.WriteLine(year + " is a Leap Year");
          }else{
            Console.WriteLine(year + " is not a Leap Year");
          }
        }else{
          Console.WriteLine(year + " is a Leap Year");
        }
      }else{
        Console.WriteLine(year + " is not a Leap Year");
      }
      //checking if the year is a leap year or not using single if statement with logical operators
      if((year%4==0 && year%100!=0) || (year%400==0)){
        Console.WriteLine("(Using Logical Operators) " + year + " is a Leap Year");
      }else{
        Console.WriteLine("(Using Logical Operators) " + year + " is not a Leap Year");
      }
    }else{
      Console.WriteLine("Please enter a valid year greater than or equal to 1582");
    }
  }
}