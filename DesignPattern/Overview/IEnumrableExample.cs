using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class IEnumrableExample
    {
        static void Main(string[] args)
        {
            List<int> listData = new List<int>() { 6, 7, 3, 3, 1, 7, 4, 3, 7, 2, 8, 5, 7, 4 };

            foreach (var index in GetListIndex1(listData, 7))
                Console.Write(index + " ");

            Console.WriteLine();

            foreach (var index in GetListIndex2(listData, 7))
                Console.Write(index + " ");

        }

        static List<int> GetListIndex1(List<int> listData, int valueFind)
        {
            List<int> listIdx = new List<int>();
            for (int ii = 0; ii < listData.Count; ii++)
            {
                if (listData[ii] == valueFind)
                    listIdx.Add(ii);
            }
            return listIdx;
        }

        static IEnumerable<int> GetListIndex2(List<int> listData, int valueFind)
        {
            for (int ii = 0; ii < listData.Count; ii++)
            {
                if (listData[ii] == valueFind)
                    yield return ii;
            }
        }
    }
}
