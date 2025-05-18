using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Abstraction_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }

    public class MyClass:IDeneme
    {
        public void deneme(int b)
        {
            Console.WriteLine("merhaba");
        }


    }

    class MyClass1 : IDeneme
    {
        public void deneme(int a)
        {
            
        }
    }

    interface IDeneme
    {
        void deneme(int a);

        
    }
}
