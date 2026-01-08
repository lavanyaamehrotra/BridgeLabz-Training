using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.employee_wage{
  sealed class EmployeeMenu{
    private IEmployee employeeUtility;// Interface for employee operations
    public void Menu(){
      employeeUtility = new EmployeeUtilityImpl();
      Console.WriteLine("Welcome to Employee Wage Computation on Master Branch");
      Console.WriteLine("\nUC 0 : Add Employee\n");
      //UC0 - ADD EMPLOYEE
      Console.Write("Enter Employee Name : ");
      string name = Console.ReadLine();
      Console.Write("Enter Employee Id : ");
      int id = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter Employee Salary : ");
      int salary = Convert.ToInt32(Console.ReadLine());
      Employee emp = employeeUtility.AddEmployee(name, id, salary);
      Console.WriteLine("\nEmployee Added Successfully!\n");
      // Display added employee details
      Console.WriteLine(emp.ToString());
      // UC1 - CHECK ATTENDANCE
      Console.WriteLine("\nUC 1 : Check Attendance\n");
      employeeUtility.CheckAttendance(emp);
      //UC2-CALCULATE DAILY WAGE
      Console.WriteLine("\nUC 2 : Calculate Daily Wage\n");
      employeeUtility.CalculateDailyWage(emp);
      // UC-3 : PART TIME WAGE
      Console.WriteLine("\nUC-3 : Part Time Employee Wage\n");
      employeeUtility.CalculatePartTimeWageUC3(emp);

    }
  }
}
