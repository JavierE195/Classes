using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Employee : Person
    {
        public double salary;

        public Employee()
        {
            salary = 5000000;
        }

        public Employee(double _salary)
        {
            salary = _salary;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Salary: " + salary);
        }
    }
}
