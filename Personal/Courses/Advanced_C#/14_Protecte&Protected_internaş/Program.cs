using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Protecte_Protected_internaş
{
    internal class Program
    {
        static void Main(string[] args)
        {
             

            Console.ReadKey();
        }
    }

    class A:B
    {
       public void yaz() 
        {
            y = 0;
            x = 1;
        }
    }

    class B 
    {
        protected int x;
        protected internal int y;

        // protected kendisi ile kalıtılmış classlarda kullanılabilmesini sağlar
        // protected internal aynı asmblyden olmasada kalıtılan classlardan ulaşılabilinir.
    } 

}
