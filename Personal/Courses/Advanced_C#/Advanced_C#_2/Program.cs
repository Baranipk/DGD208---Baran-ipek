using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,,] dizi = { { { 5, 9, 30, 24 }, { 15, 14, 12, 4 } }, { { 1, 2, 38, 29 }, { 11, 19, 52, 74 } } };

            Console.WriteLine(dizi[1,0,2]);

            Console.ReadLine();
        }
    }
}
