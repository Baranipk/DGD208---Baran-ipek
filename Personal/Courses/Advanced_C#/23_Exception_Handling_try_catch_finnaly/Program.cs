using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Exception_Handling_try_catch_finnaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("BİR SAYI GİRİNİZ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("BİR SAYI GİRİNİZ");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("Sonuç : " + (x / y));

            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("SIFIRLA BÖLME İŞLEMİ YAPILAMAZ!!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("int sınırlarını aştınız");
            }

            catch (FormatException)
            {
                Console.WriteLine("Bir tam sayı girmeniz gerekiyor.");
            }

            catch
            {
                Console.WriteLine("Bir hata oluştu!. ");
            }

            finally
            {
                Console.WriteLine("Final! ");
            }
            Console.ReadKey();
        }
    }
}
