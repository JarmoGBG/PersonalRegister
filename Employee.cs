using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Employee
    {
        private string name;
        private int salary;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string Name { get { return name; } }    
        public int Salary { get {  return salary; } }               
    }
}
