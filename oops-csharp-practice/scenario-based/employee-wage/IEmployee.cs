using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabzTraining.employee_wage{
    internal interface IEmployee{ // Interface for Employee operations
        Employee AddEmployee(string name, int id, int salary);
    }
}
