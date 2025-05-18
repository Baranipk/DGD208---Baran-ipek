using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A nesne = new A();

            

            Console.ReadKey();
        }
    }

    class A : B
    {
        public A():base() 
        {
            Console.WriteLine("A");
        }

        public A(int x):base(x) 
        { 
            Console.WriteLine("A "+x);
        }


        //public void Yaz() 
        //{
        //    base.Yaz();
        //    Console.WriteLine("A:B");
        //}
    }


    class B 
    {
        public B() 
        {
            Console.WriteLine("B");
        }

        public B(int y) 
        {
            Console.WriteLine("B "+y);
        }

        //public void Yaz()
        //{
        //    Console.WriteLine("B");
        //}
    }
}
