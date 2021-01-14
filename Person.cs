using System;
using System.Collections.Generic;
using System.Text;

namespace HW1401VirtOver
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
