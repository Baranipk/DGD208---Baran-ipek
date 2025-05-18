using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_This_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A nesne = new A(6,7,78);

            Console.WriteLine(nesne.x);
            Console.WriteLine(nesne.y);
            Console.WriteLine(nesne.z);

            Console.ReadKey();
        }
    }

    class A 
    {
        public int x;

        public int y;

        public int z;

        public A(int x)  
        {
            this.x = x;
        }

        public A(int x,int y , int z):this(x)
        {
            this.y = y;
            this.z = z;
        }
    }
}
