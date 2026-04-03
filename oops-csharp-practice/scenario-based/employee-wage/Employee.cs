using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabzTraining.employee_wage{
  public class Employee{
  private string employeeName;
  private int employeeId;
  private int employeeSalary;
  public string EmployeeName{
    get => employeeName;
    set => employeeName = value;
  }
  public int EmployeeId{
    get => employeeId;
    set => employeeId = value;
  }
  public int EmployeeSalary{
    get => employeeSalary;
    set => employeeSalary = value;
  }
  public override string ToString(){// Override ToString method to display employee info
    return $"Employee Id: {EmployeeId}, Name: {EmployeeName}, Salary: {EmployeeSalary}";
  }
}
}
