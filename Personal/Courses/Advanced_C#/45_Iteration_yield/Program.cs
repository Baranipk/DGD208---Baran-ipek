using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _45_Iteration_yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iterasyon yield

            int[] array = new int[10] {1,2,4,5,6,-10,20,-13,6,45 };

            foreach (var item in Metot1(array)) 
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }

        static IEnumerable Metot1(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] >= 0)
                {
                    yield return dizi[i];

                }               
            }
        }
    }
}
