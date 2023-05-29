

namespace Anoymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sanpham = new
            {
                Ten = "Ipone 8",
                Gia = 1000
            };

            Console.WriteLine(sanpham.Ten);


            //ex2

            List<SinhVien> list = new List<SinhVien>()
            {
                new SinhVien() { Ten = "NAM", NamSinh = 2000 },
                new SinhVien() { Ten = "Hung", NamSinh = 1000 }
            };
            var ketqua = from sv in list
                         where sv.NamSinh == 1000
                         select new
                         {
                             Ten = sv.Ten,
                             NS = sv.NamSinh
                         };
            foreach (var sv in ketqua)
            {
                Console.WriteLine(sv.Ten + "-" + sv.NS);
            }

            //ex3 dynamic
            dynamic a; //khong can gan gia tri
            var b = 1;//phai gan gia tri luon

            //int abc = 1;
            //PrintInfo(abc);
            //truong hop tren khong dc vi bien abc khong co name

            SinhVien a1 = new SinhVien();
            PrintInfo(a1);
        }

        static void PrintInfo(dynamic obj)
        {
            obj.Ten = "ads";
            obj.Hello();
        }

        class SinhVien
        {
            public String Ten { get; set; }
            public int NamSinh { get; set; }

            public void Hello ()
            {
                Console.WriteLine (Ten);
            }
        }
    }
}