using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_static_nonstatic
{
    internal class Program
    {
        static void Main(string[] args)// static vs non static
        {
           Insan ins1 = new Insan();
           Insan ins2 = new Insan();

            ins1.isim = "Mike";
            ins2.isim = "Jack";

            Insan.parmakSayisi = 20;

            Console.ReadKey();

            
        }
        
        static void yazdir(string text) 
        {
            Console.WriteLine(text); 
        }
    }

    class Insan 
    {
       public string isim { get; set; }
       static public int parmakSayisi { get; set; } // 20


    }
}


