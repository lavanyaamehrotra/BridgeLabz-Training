// Problem 2: Date Arithmetic
// Create a program that:
// ● Takes a date input and adds 7 days, 1 month, and 2 years to it.
// ● Then subtracts 3 weeks from the result.
// Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
// and DateTime.AddWeeks() methods.
using System;
class DateArithmetic{
  static void Main(string[] args){
    Console.Write("Enter a date (yyyy-MM-dd): ");
    string input = Console.ReadLine();
    DateTime date = Convert.ToDateTime(input);
    Console.WriteLine("Original Date: " + date.ToString("yyyy-MM-dd"));
    // Add 7 days
    date = date.AddDays(7);
    Console.WriteLine("After adding 7 day" + date.ToString("yyyy-MM-dd"));
    // Add 1 month
    date = date.AddMonths(1);
    Console.WriteLine("After adding 1 month" + date.ToString("yyyy-MM-dd"));
    // Add 2 years
    date = date.AddYears(2);
    Console.WriteLine("After adding 2 year" + date.ToString("yyyy-MM-dd"));
    // Subtract 3 weeks (3 * 7 = 21 days)
    date = date.AddDays(-21);
    Console.WriteLine("After subtracting 3 week" + date.ToString("yyyy-MM-dd"));
  }
}

