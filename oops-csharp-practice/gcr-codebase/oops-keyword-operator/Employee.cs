using System;
class Employee{
    public static string CompanyName = "BridgeLabz";
    // keeps track of total employees
    private static int totalEmployees = 0;
    // Readonly variable for Employee ID
    public readonly int Id;
    // Instance variables
    public string Name;
    public string Designation;
    public Employee(string Name, int Id, string Designation){
        this.Name = Name;           
        this.Id = Id;               
        this.Designation = Designation;
        totalEmployees++;          
    }

    // Static method to display total employees
    public static void DisplayTotalEmp(){
        Console.WriteLine($"Total employees in {CompanyName}: {totalEmployees}");
    }

    // Method to display details
    public void DisplayEmpInfo(){
    // Check if this object is an instance of Employee
        if (this is Employee){
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Designation: {Designation}");
        }
        else{
            Console.WriteLine("Not a valid Employee objec");
        }
    }
}

class Program{
    static void Main(string[] args){
        // Create employee objects
        Employee emp1 = new Employee("Lavanya Mehrotra", 123, "Software Engineer");
        Employee emp2 = new Employee("Khushi Tiwari", 321, "Project Manager");
        // Display employee details
        emp1.DisplayEmpInfo();
        Console.WriteLine();
        emp2.DisplayEmpInfo();
        Console.WriteLine();
        // Display total employees
        Employee.DisplayTotalEmp();
    }
}
