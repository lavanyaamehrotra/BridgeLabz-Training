// Problem 3: Date Formatting
// Write a program that:
// ● Displays the current date in three different formats:
// o dd/MM/yyyy
// o yyyy-MM-dd
// o EEE, MMM dd, yyyy

// Hint: Use DateTime.ToString() with custom date format strings.
using System;
class DateFormatting{
  static void Main(string[] args){
  // Get current date
  DateTime today = DateTime.Now;
  // 1: dd/MM/yyyy
  Console.WriteLine("1 (dd/MM/yyyy): " + today.ToString("dd/MM/yyyy"));
  // 2: yyyy-MM-dd
  Console.WriteLine("2 (yyyy-MM-dd): " + today.ToString("yyyy-MM-dd"));
  // Format 3: EEE, MMM dd, yyyy
  Console.WriteLine("3 (EEE, MMM dd, yyyy): " + today.ToString("ddd, MMM dd, yyyy"));
  }
}
