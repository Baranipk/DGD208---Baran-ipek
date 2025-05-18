using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvanvedC_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //overloading 

            sinif x = new sinif();



            //Console.WriteLine(Topla(5,4,2));
            //yazdir(Topla(5,4,2));


            Console.ReadKey();
        }

        class sinif 
        {
            public sinif() 
            {
                Console.WriteLine("Birinci");
            }

            public sinif(string yazi) 
            {
                Console.WriteLine(yazi);
            }

            public sinif(double sayi) 
            {
                Console.WriteLine(sayi);
            }
        }

        #region MethodOverloading

        static int Topla(int a, int b) 
        {
            return a + b;
        }

        static int Topla(int a, int b, int c) 
        {
            return a + b + c;
        }

        static double Topla(double a, double b, double c) 
        { 
            return a + b + c; 
        }

        static void yazdir(int a) 
        {
            Console.WriteLine(a);
        }

        static void yazdir(string a)
        {  
            Console.WriteLine(a); 
        }
#endregion
    }
}
