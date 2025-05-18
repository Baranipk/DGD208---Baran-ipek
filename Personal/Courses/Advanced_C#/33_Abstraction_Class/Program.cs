using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Abstraction_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }

    class DerivedClass1 : AbstractClass
    {
        public override void Deneme()
        {
            
        }
    }

    class DerivedClass2 : AbstractClass
    {
        public override void Deneme()
        {
            
        }
    }

    public class MyClass1:MyClass
    {
        
    }
    public class MyClass
    {
        
    }

    abstract class AbstractClass
    {
        abstract public void Deneme();
        public void Deneme2()
        {
            Console.Write("mal");
        }
        
    }
}
