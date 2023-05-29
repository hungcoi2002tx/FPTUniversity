namespace longdt
{
    internal class BTVNPT2
    {
        static void Main(string[] args)
        {
            Console.Write("Input the lession you want to check: ");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 2:
                    lession2();
                    break;
                case 4:
                    lession4();
                    break;
                case 5:
                    lession5();
                    break;
                case 6:
                    lession6();
                    break;
                case 7:
                    lession7();
                    break;
                default:
                    Console.WriteLine("Input 2, 4 ,5 ,6 or 7");
                    break;
            }

        }
        static void lession2()
        {
            int n = 100;
            n = n + 200;
            Console.WriteLine("n = " + n);
        }
        static void lession4()
        {
            Console.Write("Input number you want to devide: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The number is devied: ");
            while(n > 0)
            {
                Console.Write($"[{n % 10}]");
                n = n / 10;
            }
            
        }
        static void lession5()
        {
            Console.WriteLine("Input the mark: ");
            Console.Write("Diem Thi lan 1: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem Thi online: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Diem Thi cuoi ky: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Diem trung binh la: {n*0.25 + m*0.25 + h *0.5}");          
        }
        static void lession6()
        {
            Console.WriteLine("Input the length of rectange : ");
            Console.Write("Length of rectange 1: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length of rectange 2: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Perimeter of the rectange: {Math.Sqrt(n*n + m *m) + n + m}" + $"\nArea of the rectange: {n * m / 2 }");
        }
        static void lession7()
        {
            Console.WriteLine("Input the length of rectange : ");
            Console.Write("Length of rectange 1: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length of rectange 2: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length of rectange 2: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double p = (n + m + h) / 2;
            Console.Write($"Perimeter of the rectange: {m + n + h}" + $"\nArea of the rectange: {Math.Sqrt(p * (p-n) * (p-m) * (p-h))}");
        }
    }
}