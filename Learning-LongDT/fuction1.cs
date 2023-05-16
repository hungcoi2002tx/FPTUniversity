using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class fuction1
    {
        static void Addition(float a,params float[] b)
        {
            Console.WriteLine($"{a + b.Sum()}");
        }
        static void Main(string[] args)
        {
            // tu khoa params:
            float a = 5,b = 10;
            Addition(a,b,1,2,3,4);  

        }
    }
}
