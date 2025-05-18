using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Partial_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel Kisi1 = new Personel();
            Kisi1.maas = 14;

            Console.ReadKey();
        }
    }

    static partial class MyClass
    {
        // bu classa eklenen özellikler 
        static partial void Yazdir();
        // partial metotlar privatedır başka erişim belirleyici almazlar kapsulleme ile çağrılırlar

        static void YazdirMetot()
        {
            Yazdir();
        }

        
    }
    partial class MyClass
    {
        static partial void Yazdir()
        {
            Console.WriteLine();
        }

        // bu classada ekleniyor
    }
}
