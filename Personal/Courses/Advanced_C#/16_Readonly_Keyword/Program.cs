using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Readonly_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // const kullanarak atanmış değerlerde nesne oluşturmadan değer okuyabiliyoruz.
            Console.WriteLine(MyClass.PE);

            // read only ile değerleri ya ilk tanımlarken değer atayabiliyoruz yada contructorun içinde atayabiliyoruz.
            // read only ile atanmış değerlerde nesne oluşturmadan değer okuyamıyoruz.
            MyClass nesne = new MyClass(3.14);
            Console.WriteLine(nesne.PI);


            

            Console.ReadKey();
        }
    }

    class MyClass 
    {
       public readonly double PI;
       public const double PE = 4;


        //readonly ile değerleri constructor içinde atayabiliyoruz.
        public MyClass(double x) 
        {
            PI = x;
        }
    }
}
