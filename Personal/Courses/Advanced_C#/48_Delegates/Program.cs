using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen test =  new Dikdortgen(Cevre);

            Console.WriteLine(test(4, 6));

            //delegates - temsilci

            Console.ReadKey();
        }

        static double Cevre(double a, double b) 
        {
            return 2*(a + b);
        }


        static double Alan(double a,double b)
        {
            return a * b;
        }

        delegate double Dikdortgen(double a, double b);
    } 
}
