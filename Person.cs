using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Person
    {
        public string firstName;
        public string lastName;
        public static int count = 0;

        public Person()
        {
            firstName = "Henry";
            lastName = "Ford";
            count++;
        }

        public Person(string _firstName, string _lastName)
        {
            firstName = _firstName;
            lastName = _lastName;
            count++;
        }

        public void PrintPerson()
        {
            Console.WriteLine("\nName of employee number " + count + " : "  + firstName + " " + lastName);
        }
    }
}
