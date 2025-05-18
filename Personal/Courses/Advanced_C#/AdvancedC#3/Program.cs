using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[3];

            // HERHANGİ BİR ARRAYI LİST OLARAK TANIMLAYIP KULLANABİLİRSİN
            List<int> numbers = new List<int>() { 2, 6, 7, 8, -15 };

            numbers.Add(19);
            numbers.Add(-7);

            numbers.Remove(8);

            Console.WriteLine(numbers[2]); 
            Console.WriteLine(numbers.Count + "\n");
            Console.WriteLine(numbers.Contains(12) + "\n Contains");
            Console.WriteLine(numbers.BinarySearch(7) + "\n binarySearch");

            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
