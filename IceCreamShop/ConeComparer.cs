using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            string i = x.Cost.ToString();
            string j = y.Cost.ToString();
            return string.Compare(i, j);
        }
    }
}
