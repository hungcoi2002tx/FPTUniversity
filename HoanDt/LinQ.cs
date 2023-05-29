using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoanDt
{
    internal class LinQ
    {
        static void Main(string[] args)
        {
            String[] names = { "David", "Jane", "Peter", "John", "Mark" };
            var items = from word1 in names where word1.Contains("a") select word1;
            foreach(string s in items)
            {
                Console.WriteLine(s);
            }
        }
    }
}
