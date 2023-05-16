using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt5
{
    internal class B5
    {
        static void Main(string[] args)
        {
            SoNguyenTo s = new SoNguyenTo();
            SoNguyenTo s1 = new SoNguyenTo(4);
            SoNguyenTo s2 = new SoNguyenTo(5) ;
            s2.SoNguyenToTiepTheo();
            s2.A = 6;
            s2.A = 3;
        }
        public class SoNguyenTo
        {
            private int a;

            public SoNguyenTo()
            {
            }

            public SoNguyenTo(int a)
            {
                if(IsSoNguyenTo(a))
                {
                    this.a = a;
                }
                else
                {
                    Console.WriteLine($"{a} khong phai so nguyen to");
                }
            }
            public bool IsSoNguyenTo(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            public int SoNguyenToTiepTheo()
            {   
                for(int i = a+1; ; i++)
                {
                    if (IsSoNguyenTo(i))
                    {
                        return i;
                    }
                }
                return 0;
            }

            public int A
            {
                get { return a; }
                set { if (IsSoNguyenTo(a))
                    {
                        this.a = value;
                    }
                    else
                    {
                        Console.WriteLine("Khong the set so nay");
                    }
                }
            }
        }
    }
}
