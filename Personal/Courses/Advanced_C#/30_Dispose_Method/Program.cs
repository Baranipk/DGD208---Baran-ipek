using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Dispose_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dispose methodu kullanmadığımız objeleri kaldırmak için kullanılan bir methoddur. bazı frameworklerin içinde bulunur.

            Console.ReadKey();
        }

        class MyClas : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Disposed");
                 
                GC.SuppressFinalize(this); //unmanaged kodlarda kullanılır
            }
        }
    }
}
