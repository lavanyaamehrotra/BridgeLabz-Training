using System;
using System.IO;
class ReadCsv{
    static void Main(){
        string filePath = "students.csv";
        // Read all lines from the CSV file
        string[] lines = File.ReadAllLines(filePath);
        Console.WriteLine("Student Details\n");
        foreach (string line in lines){
            string[] data = line.Split(',');
            Console.WriteLine("ID: " + data[0]);
            Console.WriteLine("Name: " + data[1]);
            Console.WriteLine("Age: " + data[2]);
            Console.WriteLine("Marks: " + data[3]);
        }
    }
}
