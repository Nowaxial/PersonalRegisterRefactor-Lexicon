
using System;
using System.Numerics;

namespace PersonalRegisterRefactor
{
    internal class Program
    {
        private static Payroll payroll = new();
        static void Main(string[] args)
        {
            bool runningConsole = true;
            

            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Register Employee");
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. List employees");
                Console.WriteLine("Q. Exit");
                Console.WriteLine("----------------------");
                Console.Write("Choose a option: ");

                string chosenInput = Console.ReadLine()!.ToUpperInvariant();

                switch (chosenInput)
                {
                    case "1":
                        AddEmployee();                     
                        break;
                    case "2":
                        ShowAllEmployees();
                        break;
                    case "Q":
                        runningConsole = false;
                        break;
                    default:
                        break;
                }

            }
            while (runningConsole);
           
        }

        private static void ShowAllEmployees()
        {

            if (payroll.GetEmployees().GetEnumerator().MoveNext())
            {
                Console.WriteLine("Employees: ");
                Console.WriteLine("----------------------");
                foreach (var employee in payroll.GetEmployees())
                {
                    Console.WriteLine($"Name: {employee.FirstName} {employee.LastName} | Salary: {employee.Salary}kr");
                    Console.WriteLine("----------------------");
                }
            }
            else
            {
                Console.WriteLine("No employees registered");
            }
        }

        private static void AddEmployee()
        {
            bool isSucess = false;
            string firstName;
            string lastName;
            int salary = 0;

            do
            {
                Console.Write("Enter first name: ");
               firstName = Console.ReadLine()!;

                Console.Write("Enter last name: ");
                lastName = Console.ReadLine()!;

                Console.Write("Enter salary: ");
                string salaryInput = Console.ReadLine()!;


                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("You must enter a valid name");
                }
                else if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("You must enter a valid last name");
                }
                else if (!int.TryParse(salaryInput, out salary) || salary < 0) 
                {
                    Console.WriteLine("You must enter a valid salary");
                }
                else
                {
                    
                    isSucess = true;
                    
                }


            } while (!isSucess);
            payroll.AddEmployee(firstName, lastName, salary);
        }
    }
}
