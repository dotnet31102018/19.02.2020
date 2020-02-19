using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902_2
{
    public class CoffeeCollection
    {
        string[] beverages = new string[3] { "espresso", "macchiato", "latte" };

        public CoffeeCollection()
        {
        }

        public CoffeeEnumerator GetEnumerator()
        {
            return new CoffeeEnumerator(beverages);
        }

        public class CoffeeEnumerator
        {
            private string[] _beverages;
            public CoffeeEnumerator(string[] beverages)
            {
                _beverages = beverages;
            }
            int currentIndex = -1;

            public string Current
            {
                get
                {
                    return _beverages[currentIndex]; // yield return ...
                }
            }

            public bool MoveNext()
            {
                currentIndex++;

                if (currentIndex < _beverages.Length)
                {
                    return true;
                }

                return false; // yield break
            }

            public void Reset()
            {
                currentIndex = 0;
            }

        }
    }
}
