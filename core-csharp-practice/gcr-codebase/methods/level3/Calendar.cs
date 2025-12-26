// Create a program to display a calendar for a given month and year. The program should take the month and year as input from the user and display the calendar for that month. E.g. for 07 2005 user input, the program should display the calendar as shown below

using System;
class Calendar{
    public static string GetMonthName(int month){
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    static bool IsLeapYear(int year){
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetDaysInMonth(int month, int year){
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }
    static int GetFirstDay(int month, int year){
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
        return d0;
    }

    public static void Main(){
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMonthName(month) + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        int firstDay = GetFirstDay(month, year);
        int daysInMonth = GetDaysInMonth(month, year);
        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        for (int day = 1; day <= daysInMonth; day++){
            Console.Write(day, 3);
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
