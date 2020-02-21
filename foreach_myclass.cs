using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iter2102
{
    class Program
    {
        public class DataBaseRecord { public int Data { get; set; } };
        private static DataBaseRecord ReadOneRecord() { return new DataBaseRecord(); }

        public class MyClass
        {
            private List<DataBaseRecord> records = new List<DataBaseRecord>(100000);

            public MyClass()
            {
                // read records from data base
            }

            public MyEnumerator GetEnumerator()
            {
                return new MyEnumerator(records);
            }
            public class MyEnumerator
            {
                private List<DataBaseRecord> records;
                int counter = 0;
                public MyEnumerator(List<DataBaseRecord> records)
                {
                    this.records = records;
                }
                public DataBaseRecord Current => new DataBaseRecord { Data = records[counter].Data };

                public bool MoveNext()
                {
                    if (counter >= records.Count)
                        return false;
                    return true;
                }

                public void Reset()
                {
                    counter = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            foreach (var item in new MyClass())
            {
                // .....
            }


        }
    }
}
