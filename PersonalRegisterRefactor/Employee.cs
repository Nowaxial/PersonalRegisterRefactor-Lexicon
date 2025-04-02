using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegisterRefactor
{
    internal class Employee(string firstName, string lastName, int salary)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Salary { get; set; } = salary;
    }
}
