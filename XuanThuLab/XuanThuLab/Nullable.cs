using System;

namespace XuanThuLab
{
    internal class Nullable
    {
        static void Main(string[] args)
        {
            ABC a = null;
            a.XinChao();
        }
    }
    class ABC
    {
        public void XinChao() => Console.WriteLine("Xin chao ahihi");
    }
}