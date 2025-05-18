using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_8
{
    internal class Kisi
    {
        public string _ad;
        public string _soyAd;

        public Kisi(string ad, string soyAd)
        {
            _ad = ad;
            _soyAd = soyAd;
        }

        public Kisi() { }

        public void BilgiYazdır() 
        {
            Console.WriteLine(_ad + " " + _soyAd);
        }

    }
}
