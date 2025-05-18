using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Nested_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Damar damar = new Damar();
            Damar.Kan kan = new Damar.Kan();

        }
    }
    // nested classlar iç içe yazılan classlardır yukarıdaki şekilde obje üretilebilir.
    // nested classlar üst class static olsa dahi static olmak zorunda deildir.
    class Damar // outter class
    {
        public double X;
        public class Kan // inner class
        {
            public double WBC;
            public double RBC;

            public void Metot()
            {
               // nested classlarda üst classa static olmadan erişim yoktur.
               // obje üreterek erişim sağlanabilir
            }
        }
    }
    class MyClass:Damar
    {
        // MyClass:Damar şeklinde türeyebilir
        // MyClass:Damar.kan şeklinde türeyebilir
        // Damar:MyClass Şeklinde türeyebilir
        // Kan:Damar şeklinde türeyebilir
        // Kan:Myclass Şeklinde türeyebilir
        // FAKAT Damar:Kan.Damar şeklinde türeyemez!
    }
}
