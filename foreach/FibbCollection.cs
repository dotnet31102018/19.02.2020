using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902_2
{
    public class FibbCollection
    {
        private int count = 0;
        public FibbCollection(int counter)
        {
            this.count = counter;
        }
        public FibbEnumerator GetEnumerator()
        {
            return new FibbEnumerator(count);
        }

        public class FibbEnumerator
        {
            private int count = 0;
            public FibbEnumerator(int counter)
            {
                this.count = counter;
            }
  
            int currentIndex = 0;
            int a = 1;
            int b = 1;

            public int Current
            {
                get
                {
                    if (currentIndex == 1 || currentIndex == 2)
                        return 1;
                    int c = a + b;
                    a = b;
                    b = c;
                    return c;
                }
            }

            public bool MoveNext()
            {
                currentIndex++;

                if (currentIndex < count + 1)
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
