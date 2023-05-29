using System;

namespace XuanThuLab
{
    internal class Generic
    {
        //static void Swap(ref int x, ref int y)
        //{
        //    int i;
        //    i = x;
        //    x = y;
        //    y = i;
        //}

        static void Swap1<T>(ref T x, ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }

        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine($"a = {x} ; b = {y}" );
            Swap1(ref x, ref y);
            Console.WriteLine($"a = {x} ; b = {y}");
            Swap1(ref x, ref y);
            Console.WriteLine($"a = {x} ; b = {y}");
            // nếu chúng ta đổi int x, y sang float thì method trên không thể sử dụng được
            // ==> phải dùng generic
        }
    }
}
