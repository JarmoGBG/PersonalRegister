using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Register
    {
        private List<Employee> employees;
        
        public Register()
        {
            employees = new List<Employee>();
        }
        
        public void AddEmployee(string name, int salary) 
        {
            var employee = new Employee(name, salary);
            employees.Add(employee);    
        }

        public void PrintEmployees()
        {
            Console.WriteLine("\nEmployees:");
            Console.WriteLine("----------");

            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("{0}, {1}", employee.Name, employee.Salary));
            }
        }

    }
}
