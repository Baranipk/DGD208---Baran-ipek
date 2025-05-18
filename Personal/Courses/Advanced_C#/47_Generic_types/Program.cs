using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Generic_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> a = new MyClass<int>();
            

            a.x = 3;
            a.Method(2);
            Console.ReadKey();
        }
    }

    public class MyClass<T>
    {
        public T x;

        public void Method(T b) 
        {
            Console.WriteLine(b.ToString()); 
        }
    }
}


