using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi birinciKisi = new Kisi { Ad = "ahmet", SoyAd = "kaplan", yas = 20 };

            //birinciKisi.Ad = "ahmet";
            //birinciKisi.SoyAd = "kaplan";
            //birinciKisi.yas = 18;

            birinciKisi.specs();

            Console.ReadKey();


        }
    }

    
}
