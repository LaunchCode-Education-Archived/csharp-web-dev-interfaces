using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class BonusMission : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            int onex = 0;
            int twox = 0;
             if(x.Allergens.Count > y.Allergens.Count)
                {
                onex++; 
                }
             else
            {
                twox++;
            }
            string k = onex.ToString();
            string l = twox.ToString();
            return string.Compare(k, l);
        }
    }
}
