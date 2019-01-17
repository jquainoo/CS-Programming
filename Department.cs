using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayTwo
{
    public class Department
    {
        private SortedList<int, string> employeeList;


        public Department()
        {
            employeeList = new SortedList<int, string>();
        }

        public SortedList<int, string> EmployeeList
        {
            get
            {
                return employeeList;
            }

            set
            {
                employeeList = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (employeeList != null)
                employeeList.Add(employee.EmployeeId, employee.Name);
            

        }

        public bool DeleteEmployee(Employee employee)
        {
            return employeeList.Remove(employee.EmployeeId);
        }

        public bool FindEmployee(Employee employee)
        {
            return employeeList.ContainsKey(employee.EmployeeId);
        }

    }
}
