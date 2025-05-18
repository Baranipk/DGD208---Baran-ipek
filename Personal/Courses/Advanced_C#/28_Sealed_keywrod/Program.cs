using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Sealed_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

     /* sealed */ class A 
    {
        public virtual void Deneme() { }
    }

    class B:A
    {
        public /*sealed*/ override void Deneme() { }

        // A classı sealed olarak işaretlendiği için B klasını A dan türetemiyoruz.
    }

    class C:B
    {
        public override void Deneme()
        {
            // DENEME METHODU SEALED OLDUĞU İÇİN B DE C DE ERİŞEMİYORUZ FAKAT A DAN ERİŞEBİLİRİZ
        }
    }
}


