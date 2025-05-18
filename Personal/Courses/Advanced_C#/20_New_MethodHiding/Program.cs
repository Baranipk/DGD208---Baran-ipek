using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_New_MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A refType = new A();

            refType.Write();

            Console.WriteLine();

            Console.ReadKey();
        }

    }

    public class A:B
    {
        

        new public void Write()
        {
            base.Write();
            Console.WriteLine("Merhaba");
        }
    }

    public class B
    {
        public void Write() 
        {
            Console.WriteLine("selam"); 
        }
    }
}
