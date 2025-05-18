using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ref_out
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int x;

            Console.WriteLine(bol(19,5,out x));

            Console.WriteLine(x);

            Console.ReadKey();
        }

        static int bol(int bolunen, int bolen,out int kalan) 
        {
            int bolum = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                if (bolunen > bolen)
                {
                    bolunen -= bolen;
                    bolum++;
                }

                else 
                {
                    break;
                }
            }
            kalan = bolunen;

            return bolum;
            
        }

    }
}
