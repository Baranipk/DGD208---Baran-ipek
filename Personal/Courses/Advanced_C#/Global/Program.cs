using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Global_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // global anahtar kelimesi namescapelerin üzerini işaret etmektedir global::~~~~ şeklinde kullanılır.
             // class kalıtırkende MyClass:global::Derived şeklinde tanımlama yapabiliyoruz.
     

            global::System.Console.WriteLine("Selam");
        }
    }
}
