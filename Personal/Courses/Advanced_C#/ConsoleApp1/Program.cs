using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_and_refferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stack Heap
            //değer tip      int,float,double,uint,struct...
            //referans tip-- class,object,array,interface,delegate,string

            int[] dizi = {5,-19}; 
            Console.WriteLine(dizi[0] + " " + dizi[1]);

            degistir(dizi);

            Console.WriteLine(dizi[0] + " " + dizi[1]);

            Console.ReadKey();
        }

        static void degistir(int[] x) 
        {
            x[0] = 8;
            x[1] = 15;
        }
    }

   
}
