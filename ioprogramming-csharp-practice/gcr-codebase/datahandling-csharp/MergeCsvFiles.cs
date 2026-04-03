using System;
using System.IO;
using System.Collections.Generic;
class MergeCsvFiles{
    static void Main(){
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";
        // Dictionary to store ID -> (Marks, Grade)
        Dictionary<string, string[]> marksData = new Dictionary<string, string[]>();
        // Read students2.csv (skip header)
        string[] lines2 = File.ReadAllLines(file2);
        for (int i = 1; i < lines2.Length; i++){
            string[] data = lines2[i].Split(',');
            marksData[data[0]] = new string[] { data[1], data[2] };
        }
        // Read students1.cs
        string[] lines1 = File.ReadAllLines(file1);
        // Create output CSV content
        List<string> output = new List<string>();
        output.Add("ID,Name,Age,Marks,Grade"); // header
        for (int i = 1; i < lines1.Length; i++){
            string[] data1 = lines1[i].Split(',');
            string id = data1[0];
            if (marksData.ContainsKey(id)){
                string marks = marksData[id][0];
                string grade = marksData[id][1];
                output.Add(id + "," +data1[1] + "," +data1[2] + "," +marks + "," +grade);
            }
        }
        // Write merged data to new CSV file
        File.WriteAllLines(outputFile, output);
        Console.WriteLine("Merged CSV file created: merged_students.csv");
    }
}
