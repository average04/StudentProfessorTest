using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public Student Study()
        {
            Console.WriteLine("I'm studying");
            return this;
        }

        public Student ShowAge()
        {
            Console.WriteLine($"My age is : {Age} years old");
            return this;
        }
    }
}
