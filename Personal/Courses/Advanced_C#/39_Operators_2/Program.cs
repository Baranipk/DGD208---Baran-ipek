using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Operators_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 50;

            ref int x = ref y;

            x = 90;


            Console.WriteLine(y);

            Console.WriteLine(x);

            Console.ReadKey();

            // https://www.youtube.com/watch?v=Tzq73LpLU60&list=PLa6kneNR-u-3MDmvdsRhLHYQ6fnCiqywb&index=41&ab_channel=GurkanKaraman
        }
    }
}
