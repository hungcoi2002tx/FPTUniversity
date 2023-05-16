using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class fuction
    {
        static void Demo()
        {

        }

        static void TinhTong(float a, float b)
        {

        }

        static float TinhBietThucDelta(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        static void InputData(out float a,out float b)
        {
            Console.Write("Input a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = float.Parse(Console.ReadLine());
        }

        static void ShowData(ref float a, ref float b) 
        
        {
            Console.WriteLine($"a = {a} - b = {b}");
        }
        static void Main(string[] args)
        {
            //function:

            //Tên hàm được định nghĩa với việc viết hoa ở đầu tất cả các từ
            float a, b;
            InputData(out a,out b);

            ShowData(ref a,ref b);  
        }
    }
}
