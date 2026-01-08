using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabzTraining.employee_wage{
    internal interface IEmployee{ // Interface for Employee operations
        Employee AddEmployee(string name, int id, int salary);//UC-0
         void CheckAttendance(Employee emp); // UC1
         void CalculateDailyWage(Employee emp); // UC2
         void CalculatePartTimeWageUC3(Employee emp); // UC3
        void CalculateWageUsingSwitch(Employee emp); // UC-4

    }
}
