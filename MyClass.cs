using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    internal class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }

        static MyClass()
        {
            Console.WriteLine("Статистический конструктор");
        }

        public static void Foo() { }
    }
}
