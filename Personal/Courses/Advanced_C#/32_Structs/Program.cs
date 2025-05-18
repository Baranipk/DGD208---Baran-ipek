using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct isim;

            isim.b = 50;
            Degistir(isim);

            Console.WriteLine(isim.b);

            Console.ReadKey();
        }
        static void Degistir(MyStruct a)
        {
            a.b = 30;
        }
    }

    
    struct MyStruct // value type , stack ,16 byte sınırı  vardır, destructor bulunamaz
    {
        public  int b;

        public MyStruct(int x)
        {
            b = x;
        }
    }

    public class MyClass // ref type , heap
    {
        public int x;

        ~MyClass() 
        {

        }
    }
}
