using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass x = new BaseClass();
            DerivedClass_1 y = new DerivedClass_1();
            DerivedClass_2 z = new DerivedClass_2();

            //////////////////////////////////////////////////////////

            BaseClass a = new DerivedClass_1();
            DerivedClass_1 b = new DerivedClass_2();

            x.Method();
            Console.WriteLine("--------------------");
            y.Method();
            Console.WriteLine("--------------------");
            z.Method();
            Console.WriteLine("--------------------");
            a.Method();
            Console.WriteLine("--------------------");
            b.Method();


            // override > new ( methodu gizlesen bile eğerki üstüne yazdırdığın bir method varsa o çalışır )


            Console.ReadLine();
        }
    }
}
