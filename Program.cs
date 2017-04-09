using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please insert the employee's first name: ");
            string first = Console.ReadLine();

            Console.Write("Please insert the employee's last name: ");
            string last = Console.ReadLine();

            Console.Write("Please insert the employee's salary: ");
            double sal = double.Parse(Console.ReadLine());

            Employee emp01 = new Employee();
            emp01.PrintPerson();
            emp01.PrintEmployee();

            Employee emp02 = new Employee();
            emp02.firstName = first;
            emp02.lastName = last;
            emp02.salary = sal;
            emp02.PrintPerson();
            emp02.PrintEmployee();
            Console.ReadKey();


        }
    }
}
