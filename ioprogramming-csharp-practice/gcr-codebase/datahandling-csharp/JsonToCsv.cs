using System;
using System.IO;
using System.Text.Json;
class JsonToCsv{
    static void Main(){
        var students = new[] { new { Id = 1, Name = "Lavanya" }, new { Id = 2, Name = "Khushi" } };
        string json = JsonSerializer.Serialize(students);
        File.WriteAllText("students.json", json);
        File.WriteAllLines("students_from_json.csv", new[] { "ID,Name", "1,Lavanya", "2,Khushi" });
        Console.WriteLine("JSON <-> CSV Done");
    }
}