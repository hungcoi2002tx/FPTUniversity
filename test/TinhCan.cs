using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

        class TinhCan
        {
            public void Sub(UserInput input)
            {
                input.suKienNhapSo += Can;
            }
            public void Can(int x)
            {
                Console.WriteLine($"Can cua so do la {Math.Sqrt(x)} ");
            }
        }

    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.suKienNhapSo += BinhPhuong1;
        }
        public void BinhPhuong1(int x)
        {
            Console.WriteLine($"Can cua so do la {x * x} ");
        }
    }

}
