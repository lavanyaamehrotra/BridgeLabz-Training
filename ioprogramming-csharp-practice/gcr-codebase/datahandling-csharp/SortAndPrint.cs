using System;
using System.IO;
using System.Linq;
class SortAndPrint{
    static void Main(){
        string filePath = "employees.csv";
        // Read all lines from CSV
        string[] lines = File.ReadAllLines(filePath);
        // Skip header and sort by salary (descending)
        var sortedEmployees = lines.Skip(1).Select(line => line.Split(',')).OrderByDescending(data => int.Parse(data[3])).Take(5);
        Console.WriteLine("Top 5 Highest-Paid Employees:\n");
        foreach (var emp in sortedEmployees){
            Console.WriteLine("Name: " + emp[1] +", Department: " + emp[2] + ", Salary: " + emp[3]);
        }
    }
}
