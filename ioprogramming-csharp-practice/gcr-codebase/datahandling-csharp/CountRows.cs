using System;
using System.IO;
class CountRows{
    static void Main(){
        string filePath = "employees.csv";
        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(filePath);
        // Subtract 1 to exclude the header row
        int recordCount = lines.Length - 1;
        Console.WriteLine("Number of records: " + recordCount);
    }
}
