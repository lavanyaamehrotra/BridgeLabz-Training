using System;
class Employee{
  private string name;
  private int id;
  private double salary;
  // Constructor
  public Employee(string name, int id, double salary){
    this.name = name;
    this.id = id;
    this.salary = salary;
  }
  // Method to display employee details
  public void DisplayDetails(){
    Console.WriteLine("Employee Details:");
    Console.WriteLine("Name: " + name);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Salary: " + salary);
    }
  // Main method
  static void Main(string[] args){
    // Create Employee object
    Employee emp = new Employee("John Doe", 101, 55000.50);
    // Display details
    emp.DisplayDetails();
  }
}
