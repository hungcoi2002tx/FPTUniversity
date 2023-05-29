using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class @delegate
    {
        //dinh nghia delegate:
        public delegate long Dele1(int a, int b);

        //demo nest delegate:
        public delegate void Dele2(String s);
        static long Addition(int a, int b) => a + b;

        static void Show1(Dele2 dele2, String sms){
            dele2(sms);
        }

        //demo multicast delegate
        public delegate void Dele3();


        //demo anonimous delegate
        public delegate void Dele5(int a, int b);   

        public delegate double Dele6(String s);
        static void Show6(String s)
        {
            Console.WriteLine(s);
        }
        static double multi(float a, float b) { return a * b; }
        static void Main(string[] args)
        {
            //Delegate: <=> Con trỏ hàm trong C.

            //delegate: cần phải có những signature tương tự như phương thức: Kiểu, số lượng, tham số, kiểu tham số.
            //delegate: có thể được tạo cả ở trong và ngoài lớp 
            Dele1 dele = new Dele1(Addition);
            //thuc thi dele
            Console.WriteLine(dele(1, 2));

            //cách trỏ khác
            Dele1 dele1 = Addition;
            Console.WriteLine(dele1(1, 2));


            //demo nest delegate
            Console.WriteLine("Demo nest delegate");
            void Show(String sms)
            => Console.WriteLine(sms.ToUpper());

            Show1(Show, "programming");


            //demo multicast delegate:
            // một delegate có thể trỏ đến nhiều phương thức, ngoài ra có thể trỏ đến 1 phương thức nhiều lần
            //sử dụng tóan tử += để cho delegate trỏ thêm vào phương thức mong muốn
            //sử dụng toán tử -= để trừ delefate
            Console.WriteLine("Demo multicast delegate");
            void Show2(){
                Console.WriteLine("aaaa");
            }
            void Show3()
            {
                Console.WriteLine("bbbb");
            }
            Dele3 dele3 = Show2;
            dele3 += Show3;

            dele3();


            Console.WriteLine("Demo anonimous method");
            Dele5 dele5 = delegate (int a, int b)
            {
                Console.WriteLine($"{a + b}");  

            };
            Dele5 dele6 = (int a, int b) =>
            
                Console.WriteLine($"{a + b}");

            dele5(10, 20);

            //generic delegateL xay dung san
            //Func<>: su dung cho cac phuong thuc co kieu tra ve khac void, mang 16 tham so kieu, tham so kieu cuoi la kieu tra ve cua phuong thuc
            //Action<> su dung cho cac phuong thuc co kieu tra ve laf void
            Console.WriteLine("demo generic delegate");
            Func<float, float, double> fc = multi;
            Console.WriteLine(fc(3,4)); 
            Action<String> fc1 = Show6;
            fc1("dasdsad");
        }
    }
}
