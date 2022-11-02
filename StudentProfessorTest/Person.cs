using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        public int Age { get; set; }

        public Person Greet()
        {
            Console.WriteLine("Hello from "+ this.GetType().Name);
            return this;
        }

        public Person SetAge(int age)
        {
            Age = age;
            return this;
        }
    }
}
