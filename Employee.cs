using System;
using System.Collections.Generic;
using System.Text;

namespace HW1401VirtOver
{
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }


        //public override void Display()
        //{
        //    Console.WriteLine($"{Name} работает в {Company}");     добавляет работает в Майкрасофт
        //}
    }

}
