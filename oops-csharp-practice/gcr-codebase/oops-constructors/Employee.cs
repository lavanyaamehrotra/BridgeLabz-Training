using System;
class Employee{
    // Attributes of the class
    public int employeeID;     
    protected string department;  
    private double salary;        
    // Constructor
    public Employee(int id, string dept, double salary){
      employeeID = id;
      department = dept;
      this.salary = salary;
    }
    // Modify salary 
    public void UpdateSalary(double newSalary){
      salary = newSalary;
    }
    // Access salary 
  public double GetSalary() {
    return salary;
  }
}
// Subclass of Employee
class Manager : Employee{
  public Manager(int id, string dept, double salary): base(id, dept, salary) { }
  // Display employee details
  public void Display(){
    Console.WriteLine("\nEmployee ID: " + employeeID);
    Console.WriteLine("Department: " + department);
    Console.WriteLine("Salary: " + GetSalary());
  }
}
class EmployeesRecord{
    public static void Main(string[] args){
      // Creating an object of the Manager class
      Manager mgr = new Manager(501, "IT", 80000);
      // Displaying employee details
      mgr.Display(); 
      // Updating salary
      mgr.UpdateSalary(90000);
      // Displaying updated salary
      Console.WriteLine("Updated Salary: " + mgr.GetSalary());
    }
}