using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{

    public class yieldExample
    {
        static int GetNumberX()
        {
            return 5;
        }
        
        static IEnumerable<int> GetNumber()
        {
            yield return 5;
            yield return 10;
            yield return 15;
        }
        static void Main()
        {
            Console.WriteLine(GetNumberX()); 

            foreach (int i in GetNumber())
                Console.WriteLine(i); 
        }
    }
}
