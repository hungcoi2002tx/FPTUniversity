using System;

namespace ConsoleApp1
{
    class Foundation
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //xinchao1("Hung dz");
            //set color for text
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //set default color
            //    Console.ResetColor();
            //set background color
            //   Console.BackgroundColor = ConsoleColor.DarkRed;


            //input value
            // Console.ReadKey();
            //input value until ENTER
            //String s = Console.ReadLine();
            //xinchao1(s);

            //float a, b;
            //Console.Write("Nhap float a : ");
            //String sinput = Console.ReadLine();
            //Covert String to Float 
            //a = float.Parse(sinput);

            //Console.Write("Nhap float b : ");
            //sinput = Console.ReadLine();
            //Covert String to Float 
            //b = Convert.ToSingle(sinput);
            //Console.WriteLine();
            //Console.WriteLine("So a = {0}, b = {1}",a,b);


            //mảng
            int[] arr = { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine($"{arr[0]}");
            VuKhi sungluc = new VuKhi();
        }
        static void xinchao1(String s)
        {
            // alex hung fan mu z

            Console.WriteLine("xin chao " + s);
        }
    }
    class abc
    {
        static void xinchao(String s)
        {
            Console.WriteLine("Hello " + s);
        }
    }
}
