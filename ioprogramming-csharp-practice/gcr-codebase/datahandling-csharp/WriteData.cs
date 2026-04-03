using System;
using System.IO;
class WriteData{
    static void Main(){
        string filePath = "employees.csv";
        string[] employees =
        {
            "1,Lavanya,HR,45000",
            "2,Khushi,Finance,55000",
            "3,Roshni,IT,60000",
            "4,Harshita,Marketing,48000",
            "5,Soumya,Operations,52000"
        };
        // Write data to CSV file
        File.WriteAllLines(filePath, employees);
        Console.WriteLine("Employee data written to employees.csv successfully.");
    }
}
