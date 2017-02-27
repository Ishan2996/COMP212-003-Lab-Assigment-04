using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab04_Ex03
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee() : this("MS Dhoni", 100000)
        {
        }

        public override string ToString()
        {
            return String.Format($"Name: {Name} || \tSalary:{Salary}");
        }
    }
}
