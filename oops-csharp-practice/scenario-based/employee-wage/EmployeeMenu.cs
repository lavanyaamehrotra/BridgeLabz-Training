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
      Console.WriteLine("\nUC 2/3/4 : Combined\n");
      employeeUtility.CalculateWageUsingSwitch(emp); // UC-2/3/4 combined
      // UC5 - Calculate Monthly Wage
      Console.WriteLine("\nUC5 : Calculate Monthly Wage\n");
      employeeUtility.CalculateMonthlyWage(emp, 20);
      // UC6 - Calculate Wages till condition of total hours or day
      Console.WriteLine("\nUC6 : Calculate Wages Till Condition (100 hours or 20 days)\n");
      employeeUtility.CalculateWageTillCondition(emp, 100, 20);
    }
  }
}
