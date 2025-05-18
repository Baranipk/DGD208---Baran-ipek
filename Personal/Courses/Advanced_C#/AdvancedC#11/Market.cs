using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_11
{
    internal class Market
    {
        private string cost;

        public string Cost 
        {
            get 
            {
                return cost;
            }

            set 
            {
                if (value=="0TL") 
                {
                    cost = "free";
                }

                else 
                {
                    cost = value;
                }
                
            }
        }
    }
}
