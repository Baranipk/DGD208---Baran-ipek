using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collections list = new Collections();
            list[0] = 15;
            Console.WriteLine(list[0]);

            Console.ReadKey();


        }

        public class Collections
        {
            private int[] array = new int[10];

            public int this[int i]
            {
                get { return array[i]; }
                set { array[i] = value; }
            }

        }
    }
}
