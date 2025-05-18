using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_AbstractClass_Interface_Diff
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class MyClass 
    {
        // soyut sınıflarda constractor ve destructor kullanılabilir.
        // soyut olmayan üyeler soyut üyeler ile beraber barınabilir.
        // erişim belirleyicisi kullanılabilir.
        // abstract classlar sadece 1 klass ile kalıtılabilir
        // interfacelere göre bir tık daha hızlıdırlar
    }

    interface IInterface
    {
        // interfacelerde constractor ve destructor KULLANILAMAZ!.
        // muhakkak her şey soyut olmalıdır.
        // default olarak publicdir erişim belirleyicisi değişemez.
        // interfaceler çoklu kalıtım desteklerler ve classlarla beraber kalıtılabilirler.
    }
}   

