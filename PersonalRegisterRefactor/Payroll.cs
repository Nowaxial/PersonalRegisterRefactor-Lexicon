using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegisterRefactor
{
    internal class Payroll
    {
        private List<Employee> employees;

        public Payroll()
        {
            employees = [];
        }

        internal void AddEmployee(string firstName, string lastName, int salary)
        {
            employees.Add(new Employee(firstName, lastName, salary));
        }

        internal IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
