using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HoanDt
{   
    public delegate int MyDelegate(int x,int y);
    class delegates
    {
        static int Add(int numOne, int numTwo) => numOne + numTwo;
        static int Subtract(int numOne, int numTwo) => (numOne - numTwo);
        static void Main(string[] args)
        {
            int numOne = 0;
            int numTwo = 1;
            MyDelegate delegate1 = new MyDelegate(Add);
            int result = delegate1(0, 1);
            Console.WriteLine(delegate1(0, 1)); 
        }
    }
}
