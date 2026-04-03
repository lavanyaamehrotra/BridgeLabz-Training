using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Employee{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public double Salary { get; set; }
}
class Serialization{
    static void Main(){
        string filePath = "employees.json";
        List<Employee> employees = new List<Employee>(){
            new Employee { Id = 1, Name = "Lavanya", Department = "CS", Salary = 50000 },
            new Employee { Id = 2, Name = "Khushi", Department = "IT", Salary = 55000 }
        };
        try{
            // Serialize (write to file)
            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Employee data saved.\n");
            // Deserialize (read from file)
            string readData = File.ReadAllText(filePath);
            List<Employee> loadedEmployees =JsonSerializer.Deserialize<List<Employee>>(readData);
            Console.WriteLine("Employee data read from file:\n");
            foreach (Employee emp in loadedEmployees){
                Console.WriteLine("ID: " + emp.Id);
                Console.WriteLine("Name: " + emp.Name);
                Console.WriteLine("Department: " + emp.Department);
                Console.WriteLine("Salary: " + emp.Salary);
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.ReadLine();
    }
}
