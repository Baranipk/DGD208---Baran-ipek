using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;

            char[] dizi = "Merhaba".KarakterlereCevir();

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }

    static class Extensions 
    {
        public static char[] KarakterlereCevir(this string text) 
        {
            char[] chars = new char[text.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[i];
            }

            return chars;
        } 
    }
}
