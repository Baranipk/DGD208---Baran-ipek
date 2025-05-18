using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Anonymous_types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // annonymous types içerisine parametre alabilir fakat tür alamazlar ve sadece readonly çalışırlar.
            // anonymous typelarda içerisinde nested yapıyı desteklerler.
            // anonymous typelar class oluşturmadan nesne oluşturmamızı sağlarlar.
            // linq sorgularında kullanılırlar.

            var deneme = new { a = 15 , b = "selam" , c = 65.4, d = new { isim = "hasan" } };
            

            Console.WriteLine( deneme.a );

            Console.ReadKey();  

        }
    }

   
}
