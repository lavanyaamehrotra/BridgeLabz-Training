using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.employee_wage{
  public class EmployeeUtilityImpl : IEmployee{
    public Employee AddEmployee(string name, int id, int salary){
      Employee emp = new Employee{// Create new Employee object
      EmployeeName = name,
      EmployeeId = id,
      EmployeeSalary = salary
      };
      return emp;
    }
    //UC-1
    public void CheckAttendance(Employee emp){ 
      Random random = new Random();
      int attendance = random.Next(0, 2); 
      if(attendance == 1){
        Console.WriteLine($"{emp.EmployeeName} is Present");
      }else {
        Console.WriteLine($"{emp.EmployeeName} is Absent");
      }
    }
  }
}
