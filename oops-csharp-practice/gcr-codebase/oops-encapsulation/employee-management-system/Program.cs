using System;
class Program{
  static void Main(){
    // Full-time employee object
    Employee emp1 = new FullTimeEmployee(101,"Lavanya Mehrotra",20000,30000);
    // Part-time employee object
    Employee emp2 = new PartTimeEmployee(102,"Khyati Sharma",10000,80,200);
    emp1.AssignDepartment("Software Engineer");
    emp2.AssignDepartment("System Analyst");
    Employee[] employees = { emp1, emp2 };
    foreach (Employee emp in employees){
      emp.DisplayDetails();
    }
    Console.ReadLine();
  }
}
