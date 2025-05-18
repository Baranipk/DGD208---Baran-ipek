using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace;

namespace _41_Name_Spaces
{
    using Konsol = Console;
    // sahte isim verip kullanımını kendimize göre ayarlayabiliyoruz

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Metot();

            Konsol.WriteLine("deneme");
            Console.ReadKey();
        }
    }
}

namespace MyNamespace
{
    public class MyClass:IInterface
    {
        public void Metot()
        {
            Console.WriteLine("merhaba");
        }

        public void Yaz()
        {
            Console.WriteLine("Selam");
        }
    }

    public interface IInterface
    {
        void Yaz();
    }
}
