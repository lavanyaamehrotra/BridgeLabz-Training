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
  }
}
