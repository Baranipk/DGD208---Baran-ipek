using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Polymorphism
{
    internal class BaseClass
    {
        public void Method() 
        {
            Console.WriteLine("BaseClass - Method");
        }
    }

    class DerivedClass_1 : BaseClass 
    {
        public new virtual void Method() 
        {
            Console.WriteLine("DerivedClass_1 - Method");
        }
    }

    class DerivedClass_2 : DerivedClass_1 
    {
        public override void Method() 
        {
            Console.WriteLine("DerivedClass_2 - Method");
        }
    }

}
