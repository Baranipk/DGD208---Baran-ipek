using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi birinciK = new Kisi("XYZ","abc");
            Kisi ikinciK = new Kisi();

            ikinciK._ad = "xzy";
            ikinciK._soyAd = "bac";

            birinciK.BilgiYazdır();
            Console.WriteLine("--------------");
            ikinciK.BilgiYazdır();



            Console.ReadKey();
        }
    }
}
