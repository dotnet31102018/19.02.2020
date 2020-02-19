using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    class Program
    {
        public static IEnumerable<int> Fibb(int number)
        {
            int a = 1;
            int b = 1;

            yield return 1;
            if (number <= 1)
                yield break;

            yield return 1;
            if (number <= 2)
                yield break;

            int counter = 2;
            while (true)
            {
                int c = a + b;
                a = b;
                b = c;
                yield return c;
                counter++;
                if (counter == number)
                    yield break;
            }

        }

        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            foreach (int value in Fibb(15))
            {
                Console.WriteLine(value);
                items.Add(value);
            }
        }
    }
}
