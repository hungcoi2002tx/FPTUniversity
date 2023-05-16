using System;
using System.Collections;
using System.Collections.Generic;

namespace ChiLePhuong
{
    public class main
    {
        static void Main(string[] args)
        {
            Student student = new SeStudent(2, "kha", "SE");
            Console.WriteLine(student.language());
            

        }
        public static void DemoArrayList()
        {   
            //demo 1
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);

            int sum = (int)array[0] + (int)array[1];
            Console.WriteLine(sum);

            //demo 2
            // co the add 1 object khac vao cung 1 arraylist. nhưng sẽ gặp nhiều khó khăn ở khâu lấy nó ra
            ArrayList arr2 = new ArrayList();
            arr2.Add(new Student(1,"hung"));
            arr2.Add(new Student(2, "hai"));
            arr2.Add(new Student(3, "hien"));
            arr2.Add(1);
            //((Student)arr2[3]).language(); // lỗi runtime
        }

        public static void DemoList()
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
                list1.Add(2);                
            list1.Add(3);
            // list1.Add("acb"); lỗi compile
            int sum = list1[0] + list1[1];
            Console.WriteLine(sum);
        }
    }
}
