using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.employee_wage{
  public class EmployeeUtilityImpl : IEmployee{
    private const int WagePerHour = 20;
    private const int FullDayHour = 8;
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
     // UC2 - Calculate Daily Wage
    public void CalculateDailyWage(Employee emp){
        int dailyWage = WagePerHour * FullDayHour;

        Console.WriteLine($"\nUC 2 : Calculate Daily Wage");
        Console.WriteLine($"Wage per Hour  : {WagePerHour}");
        Console.WriteLine($"Full Day Hours : {FullDayHour}");
        Console.WriteLine($"Daily Wage     : {dailyWage}");
    }
  }
}
