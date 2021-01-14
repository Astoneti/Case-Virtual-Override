using System;

namespace HW1401VirtOver
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display(); // вызов метода Display из класса Person

            Console.ReadKey();
        }
    }
}
