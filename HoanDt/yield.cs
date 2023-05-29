using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanDt
{
    internal class yield
    {
        static void Main(string[] args)
        {
            foreach (int number in GetEvenNumbers(10))
            {
                Console.WriteLine(number);
                Console.WriteLine("1");
            }
        }
        public static IEnumerable<int> GetEvenNumbers(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
