using System;

namespace XuanThuLab
{
    internal class Nullable
    {
        static void Main(string[] args)
        {
            ABC a = new ABC();
            //if(a != null)
            //{
            //    a.XinChao();
            //}
            a?.XinChao();
            
        }
    }
    class ABC
    {
        public void XinChao() => Console.WriteLine("Xin chao ahihi");
    }
}