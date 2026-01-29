using System;
using System.IO;
class ModifyFile{
    static void Main(){
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";
        // Read all lines from input CSV
        string[] lines = File.ReadAllLines(inputFile);
        // Create array to store updated records
        string[] updatedLines = new string[lines.Length];
        // Copy header row as it is
        updatedLines[0] = lines[0];
        // Process each record
        for (int i = 1; i < lines.Length; i++){
            string[] data = lines[i].Split(',');
            string department = data[2];
            double salary = double.Parse(data[3]);
            // Increase salary by 10% for IT department
            if (department == "IT"){
                salary = salary + (salary * 0.10);
            }
            // Rebuild CSV line
            updatedLines[i] =data[0] + "," +data[1] + "," +department + "," +salary;
        }
        // Write updated data to new CSV file
        File.WriteAllLines(outputFile, updatedLines);
        Console.WriteLine("Updated salary records saved to updated_employees.csv");
    }
}
