using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Explicit_implicit_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte a = 24;

            // int b = a;
            // byteın alabilceği tüm değerler intde alabilceği için sıkıntı yok ama inti byte a çevirmek istediğimizde
            // intin tüm değerlerini byte alamayacağı için tür dönüşümü yapmamız gerekmekde 

            int a = 254;

            byte b = (byte)a; // explicit casting

            int c = a; // implicit casting


            MyClass nesne = new MyClass();

            nesne.sayi = 15;

            int d = nesne;


            Console.WriteLine(d);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public int sayi;


        // implicit ve explicit operatorlerinide overloadlayabiliyoruz
        public static implicit operator int(MyClass a) 
        {
            return a.sayi;
        }
    }
}
