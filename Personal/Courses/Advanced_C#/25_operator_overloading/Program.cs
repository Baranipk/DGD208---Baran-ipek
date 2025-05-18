using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass { X=10};
            MyClass y = new MyClass { X=20};

            MyClass z = x + y;

            Console.WriteLine(z.X);

            Console.ReadKey();
        }       
    }

    class MyClass 
    {

        public int X { get; set; }
        public static MyClass operator +(MyClass left, MyClass right) 
        {
            return new MyClass {X = left.X + right.X};
        } 
           
    }
}
