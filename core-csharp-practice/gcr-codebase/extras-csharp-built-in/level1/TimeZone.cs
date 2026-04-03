// 1. Problem 1: Time Zones and DateTimeOffset
// Write a program that displays the current time in different time zones:
// ● GMT (Greenwich Mean Time)
// ● IST (Indian Standard Time)
// ● PST (Pacific Standard Time)
// Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.
using System;
class TimeZone{
  static void Main(string[] args){
    // Get current UTC time
    DateTimeOffset utctime = DateTimeOffset.UtcNow;
    Console.WriteLine("Current UTC Time: " + utctime);

    // GMT (Greenwich Mean Time)
    TimeZoneInfo gmtzone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
    DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utctime, gmtzone);
    Console.WriteLine("GMT Time: " + gmtTime);

    // IST (Indian Standard Time)
    TimeZoneInfo istzone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
    DateTimeOffset isttime = TimeZoneInfo.ConvertTime(utctime, istzone);
    Console.WriteLine("IST Time: " + isttime);

    // PST (Pacific Standard Time)
    TimeZoneInfo pstzone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
    DateTimeOffset psttime = TimeZoneInfo.ConvertTime(utctime, pstzone);
    Console.WriteLine("PST Time: " + psttime);
  }
}
