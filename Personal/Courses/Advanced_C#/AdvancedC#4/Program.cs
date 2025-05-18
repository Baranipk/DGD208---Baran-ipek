using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(topla(2,4,5,6,7));

            Console.ReadKey();
        }


        static int topla(params int[] sayilar) 
        {

            int toplam = 0;

            foreach (var i in sayilar)
            {
                toplam += i;
            }
            return toplam;
        }
    }
}
