using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            FlavorComparer test1 = new FlavorComparer();
            availableFlavors.Sort(test1);
            foreach(var i in availableFlavors)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("<--------------->");

            availableCones.Sort(new ConeComparer());
            foreach (var i in availableCones)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("<--------------->");

            availableFlavors.Sort(new BonusMission());
            foreach (var i in availableFlavors)
            {
                Console.WriteLine(i);
            }
        }
    }
}
