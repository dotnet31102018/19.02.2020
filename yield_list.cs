using System;
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

        private static IEnumerable<DataBaseRecord> ReadRecords(int num)
        {
            int counter = 0;
            while (true)
            {
                yield return ReadOneRecord();
                if (++counter == num)
                    yield break;
            }
        }
        private static List<DataBaseRecord> records = new List<DataBaseRecord>(100000);

        private static IEnumerable<DataBaseRecord> ClonedListWithIterator(int num)
        {
            int counter = 0;
            while (true)
            {
                yield return new DataBaseRecord { Data = records[counter].Data }; 
                if (++counter == num)
                    yield break;
            }
        }

        static void SendMeTheRecords(IEnumerable<DataBaseRecord> records)
        {
            // ha ha ha
            // i will abuse the recors and modify them!!
            foreach (var item in records)
            {
                item.Data = -182736172;
            }
        }
        static void Main(string[] args)
        {
            
            // reading records from database

            SendMeTheRecords(ClonedListWithIterator(100000));


        }
    }
}
