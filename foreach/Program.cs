using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            CoffeeCollection.CoffeeEnumerator a = new CoffeeCollection.CoffeeEnumerator(null);
            foreach (var coffee in new CoffeeCollection())
            {
                Console.WriteLine(coffee);
            }

            foreach (var n in new FibbCollection(10))
            {
                Console.WriteLine(n);
            }


        }



    }
}
