using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    class Demo<T> where T: new()// T: tham số kiểu (Type prameter)
    {
        //fueild
        private T data;
        //property
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public override string ToString()
        {
            return $"Data: {data}";
        }

    }
    
    class Demo1
    {

    }
    interface IDemo2 { }

    class Demo2
    {
        public void ShowInfo<T>(T a)
        {
            Console.WriteLine(a);
        }
    }


        internal class Generic
    {
        static void Main(string[] args)
        {
            //generic: An Toàn kiểu, hiệu năng, linh hoạt.
            // Áp dụng cho Class, Interface , method.
            // With Class
            Demo<int> demo = new Demo<int>() { Data = 1234 };
            Console.WriteLine(demo);
            //    Demo<String> demo1 = new Demo<String>() { Data = "C#" };
            //    Console.WriteLine(demo1);

            // Ràng buộc tham số kiểu:
            //- Struct: Kiểu dữ liệu giá trị ( value ) nghĩa là các kiểu dữ liệu nguyên thủy sẽ được generic ăn còn các kiểu còn lại thì không
            //- Class: kiểu dữ liệu tham chiếu ( reference ) thì ngược lại với cái trên
            //- New: Kiểu dữ liệu mà trong đó lớp phải có chứa hàm tạo không tham số. <int cũng được vì nó được build từ class>
            //- U : thêm 1 giá trị khác tương tự T  <T có thể phụ thuộc vào kiểu U nhưng U không được là Struct>

            //Interface Generic
            //method generic
            Demo2 demo2 = new Demo2();
            demo2.ShowInfo(12);
        }
    }
}
