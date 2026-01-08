using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.employee_wage{
  public class EmployeeUtilityImpl : IEmployee{
  private const int WAGE_PER_HOUR = 20;
  private const int FULL_TIME_HOURS = 8;
  private const int PART_TIME_HOURS = 8;
  //UC-0 ADD EMPLOYEE
  public Employee AddEmployee(string name, int id, int salary){
    return new Employee { 
      EmployeeName = name, EmployeeId = id, EmployeeSalary = salary 
      };
  }
  //UC-1 CHECK ATTENDANCE
  public void CheckAttendance(Employee emp){
    Random random = new Random();
    int attendance = random.Next(0, 2);
    if (attendance == 1)
      Console.WriteLine($"{emp.EmployeeName} is Present");
    else
      Console.WriteLine($"{emp.EmployeeName} is Absent");
  }
  //UC2-CALCULATE DAILY WAGE
  public void CalculateDailyWage(Employee emp){
    int wage = WAGE_PER_HOUR * FULL_TIME_HOURS;
    Console.WriteLine($"UC-2 Full-Time Wage: {wage}");
  }
  //UC-3 PART TIME WAGE
  public void CalculatePartTimeWageUC3(Employee emp){
        int wage = WAGE_PER_HOUR * PART_TIME_HOURS;
        Console.WriteLine($"UC-3 Part-Time Wage: {wage}");
    }
    //UC4 - CALCULATE USING SWITCH CASE
    public void CalculateWageUsingSwitch(Employee emp){
      Random random = new Random();
      int empCheck = random.Next(0, 3);
      int workingHours = 0;
      switch (empCheck){
        case 1:
        Console.WriteLine($"{emp.EmployeeName} is Full-Time");
        workingHours = FULL_TIME_HOURS;
        break;
        case 2:
        Console.WriteLine($"{emp.EmployeeName} is Part-Time");
        workingHours = PART_TIME_HOURS;
        break;
        default:
        Console.WriteLine($"{emp.EmployeeName} is Absent");
        workingHours = 0;
        break;
      }
      int dailyWage = workingHours * WAGE_PER_HOUR;
      Console.WriteLine($"Daily Wage: {dailyWage}");
    }
    //UC-5 CALCULATE MONTHLY WAGE
    public void CalculateMonthlyWage(Employee emp, int workingDays){
    Random random = new Random();
    int totalWage = 0;
    for (int day = 1; day <= workingDays; day++){
        int empCheck = random.Next(0, 3);
        int workingHours = 0;
        switch (empCheck){
        case 1:
          workingHours = FULL_TIME_HOURS;
          break;
        case 2:
          workingHours = PART_TIME_HOURS;
          break;
        default:
          workingHours = 0;
          break;
        }
        int dailyWage = workingHours * WAGE_PER_HOUR;
        totalWage += dailyWage;
    }
    Console.WriteLine($"\nUC5: Total Monthly Wage of {emp.EmployeeName} for {workingDays} working days is: {totalWage}");
    }
    //UC-6 CALCULATE WAGE TILL CONDITION
    public void CalculateWageTillCondition(Employee emp, int maxHours, int maxDays){
    Random random = new Random();
    int totalHours = 0;
    int totalDays = 0;
    int totalWage = 0;
    while (totalHours < maxHours && totalDays < maxDays){
        totalDays++;
        int empCheck = random.Next(0, 3);
        int workingHours = 0;
        switch (empCheck){
          case 1:
            workingHours = FULL_TIME_HOURS;
            Console.WriteLine($"Day {totalDays}: {emp.EmployeeName} is Full-Time ({workingHours} hrs)");
            break;
            case 2:
            workingHours = PART_TIME_HOURS;
            Console.WriteLine($"Day {totalDays}: {emp.EmployeeName} is Part-Time ({workingHours} hrs)");
            break;
            default:
            workingHours = 0;
            Console.WriteLine($"Day {totalDays}: {emp.EmployeeName} is Absent (0 hrs)");
            break;
        }
        if (totalHours + workingHours > maxHours){
            workingHours = maxHours - totalHours;
        }
        totalHours += workingHours;
        int dailyWage = workingHours * WAGE_PER_HOUR;
        totalWage += dailyWage;
      }
      Console.WriteLine($"\nUC6: Total Wage of {emp.EmployeeName} till {totalHours} hours or {totalDays} days is: {totalWage}");
      Console.WriteLine($"Total Days Worked: {totalDays}, Total Hours Worked: {totalHours}");
    }
  }
}
