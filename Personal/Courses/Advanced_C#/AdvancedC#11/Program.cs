using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Market mr = new Market();

            mr.Cost = "0TL";

            Console.WriteLine(mr.Cost);


            Console.ReadKey();
        }
    }
}
