using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_DesturactionMethods_GarbageColection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass nesne = new MyClass();

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public MyClass() 
        {
            Console.WriteLine("Constructor");
        }

        ~MyClass() //Destructorlar nesne silinmeden önce çalışır ve ardından nesne silinir
        {
            Console.WriteLine("Destructor");
        }
    }
}
