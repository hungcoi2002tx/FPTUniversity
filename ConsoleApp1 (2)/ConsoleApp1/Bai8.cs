using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Bai8
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("HS001", "Nguyen Van A", 8, 8, 7, 8, 8));
            students.Add(new Student("HS002", "Nguyen Van B", 8, 8, 7, 8, 8));
            students.Add(new Student("HS003", "Nguyen Van C", 8, 8, 7, 8, 8));
            students.Add(new Student("HS004", "Nguyen Van D", 8, 8, 7, 8, 8));
            students.Add(new Student("HS005", "Nguyen Van E", 8, 8, 7, 8, 8));
            students.Add(new Student("HS006", "Nguyen Van F", 8, 8, 7, 8, 8));
            students.Add(new Student("HS007", "Nguyen Van G", 8, 8, 7, 8, 8));
            students.Add(new Student("HS008", "Nguyen Van H", 8, 8, 7, 8, 8));

            List<String> title = new List<String>();
            title.Add(" STT");
            title.Add("  Ma Hoc Sinh");
            title.Add("      Ho Va Ten");
            title.Add("      Diem He So");
            title.Add("Diem TBKT");
            title.Add("Diem Thi");
            title.Add("Diem TBMH");
            title.Add("   HS1");
            title.Add("   HS2"); 
            //
            for (int i = 0;i < 5; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }else if (i == 4)
                {
                    Console.Write("|");
                    for (int j = 0; j < 98; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                else
                {
                  
                        //if (j == 0 || j == 6 || j == 21 || j == 40 || j == 50 || j == 70 || j == 80 || j == 90 || j == 99)
                        //{
                        //    Console.Write("|");

                        //}
                        //else
                        //{
                        //    Console.Write(" ");
                        //}
                    if(i == 2)
                    {
                        Console.Write("|");
                        Console.Write($"{title[0],-5}");
                        Console.Write("|");
                        Console.Write($"{title[1],-15}");
                        Console.Write("|");
                        Console.Write($"{title[2],-22}");
                        Console.Write("|");
                        Console.Write($"{"--------------------",-20}");
                        Console.Write("|");
                        Console.Write($"{title[4],-10}");
                        Console.Write("|");
                        Console.Write($"{title[5],-10}");
                        Console.Write("|");
                        Console.Write($"{title[6],-10}");
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    if(i == 1)
                    {
                        Console.Write("|");
                        Console.Write($"{"",-5}");
                        Console.Write("|");
                        Console.Write($"{"",-15}");
                        Console.Write("|");
                        Console.Write($"{"",-22}");
                        Console.Write("|");
                        Console.Write($"{title[3],-20}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    if(i == 3)
                    {
                        Console.Write("|");
                        Console.Write($"{"",-5}");
                        Console.Write("|");
                        Console.Write($"{"",-15}");
                        Console.Write("|");
                        Console.Write($"{"",-22}");
                        Console.Write("|");
                        Console.Write($"{title[7],-10}");
                        Console.Write("|");
                        Console.Write($"{title[8],-9}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.Write($"{"",-10}");
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    
                }
                
                
            }
            for(int i=0; i<students.Count;i++)
            {
                if(i == students.Count -1)
                {
                    Console.Write("|");
                    Console.Write($"{i+1,-5}");
                    Console.Write("|");
                    Console.Write($"{students[i].id,-15}");
                    Console.Write("|");
                    Console.Write($"{students[i].name,-22}");
                    Console.Write("|");
                    Console.Write($"{students[i].HS1,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].HS2,-9}");
                    Console.Write("|");
                    Console.Write($"{students[i].tbkt,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].mark,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].tb,-10}");
                    Console.Write("|");
                    Console.WriteLine();
                    for(int j = 0; j < 100; j++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    Console.Write("|");
                    Console.Write($"{i+1,-5}");
                    Console.Write("|");
                    Console.Write($"{students[i].id,-15}");
                    Console.Write("|");
                    Console.Write($"{students[i].name,-22}");
                    Console.Write("|");
                    Console.Write($"{students[i].HS1,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].HS2,-9}");
                    Console.Write("|");
                    Console.Write($"{students[i].tbkt,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].mark,-10}");
                    Console.Write("|");
                    Console.Write($"{students[i].tb,-10}");
                    Console.Write("|");
                    Console.WriteLine();
                    Console.Write("|");
                    for (int j = 0; j < 98; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }
    }
     class Student
    {
        public String id { get; set; }
        public String name { get; set; }
        public int HS1 { get; set; }
        public int HS2 { get; set; }
        public float tbkt { get; set; }
        public int mark { get; set; }
        public float tb { get; set; }

        public Student(string id, string name, int hS1, int hS2, float tbkt, int mark, float tb)
        {
            this.id = id;
            this.name = name;
            HS1 = hS1;
            HS2 = hS2;
            this.tbkt = tbkt;
            this.mark = mark;
            this.tb = tb;
        }
    }
}
