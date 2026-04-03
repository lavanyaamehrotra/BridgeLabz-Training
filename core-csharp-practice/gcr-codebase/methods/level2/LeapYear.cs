// 3.Write a program that takes a year as input and outputs the Year is a Leap Year or not 
using System;

class LeapYear{
  static void Main(){
    Console.Write("Enter a year: ");
    int year = Convert.ToInt32(Console.ReadLine());
    // Check if year is valid
    if (year < 1582){
      Console.WriteLine("Enter other year");
      return;
    }
    bool isLeap = IsLeapYear(year);
    if (isLeap){
      Console.WriteLine(year + " is a Leap Year.");
    }else{
      Console.WriteLine(year + " is not a Leap Year");
    }
  }
  // Method to check if a year is a leap year
    static bool IsLeapYear(int y){
    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0)){
      return true;
    }else{
      return false;
    }
  }
}
