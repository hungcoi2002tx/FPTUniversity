using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuanThuLab
{

    public delegate void SuKienNhapSo(int x);

    class UserInput{
        public SuKienNhapSo sukiennhapso { get; set; }
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap vao so nguyen: ");
                String s = Console.ReadLine();
                int i = Int32.Parse(s);
                //phat su kien 
                sukiennhapso?.Invoke(i);
            }while (true);
        }
    }
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.sukiennhapso = Can;
        }
        public void Can(int i)
        {
            Console.WriteLine($"Can bac 2 cua {i} la {Math.Sqrt(i)}");
        }
    }
    class Event
    {
        static void Main(string[] args)
        {
            UserInput input = new UserInput(); 
            TinhCan tinhCan = new TinhCan();   
            tinhCan.Sub(input);
            input.Input();
        }
    }
}
