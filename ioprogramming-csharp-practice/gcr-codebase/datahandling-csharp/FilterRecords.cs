using System;
using System.IO;
class FilterRecords{
    static void Main(){
        string filePath = "students.csv";
        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Students who scored more than 80:\n");
        // Start from index 1 to skip header row
        for (int i = 1; i < lines.Length; i++){
            string[] data = lines[i].Split(',');
            int marks = int.Parse(data[3]);
            // Filter condition
            if (marks > 80){
                Console.WriteLine("ID: " + data[0] +", Name: " + data[1] +", Age: " + data[2] +", Marks: " + data[3]);
            }
        }
    }
}
