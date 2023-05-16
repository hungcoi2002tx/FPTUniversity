using System.Collections;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;

namespace ExerciseLongDT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the lession you want to check: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 3:
                    lession3();
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
        public static void lession7()
        {
            Console.Write("nhap so n : ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= x; i++)
            {
                for(int j = i;j<i + x; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
        public static void lession6()
        {
            Console.WriteLine("Image 1: ");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 2: ");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 3: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 5 - i - 1)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 4: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 5: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Math.Abs(5 - j - 1) <= i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 6: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j > i - 1 && j < 10 - i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 7: ");
            for (int i = 0; i < 10 - 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Math.Abs(5 - j - 1) > Math.Abs(5 - i - 1) && Math.Abs(5 - j) < 10 - Math.Abs(5 - i - 1))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Image 8: ");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i == 0 || i == 6 || j == 0 || j == 11)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }

        public static void lession3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 100; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            for (int i = 3; i <= 100; i = i + 3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 98; i >= 1; i = i - 7)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("tong cac so tu 1 den 50 la: " + sum);
            int sum1 = 0;
            for (int i = 50; i >= 1; i--)
            {
                sum1 = sum1 + i;
            }
            Console.WriteLine("tong cac so tu 50 den 1 la: " + sum1);
            int sum2 = 0;
            for (int i = 2; i <= 50; i = i + 2)
            {
                sum2 = sum2 + i;
            }
            Console.WriteLine("tong cac so tu chan tu 2 den 50 la : " + sum2);

            int sum3 = 0;
            for (int i = 5; i <= 100; i = i + 5)
            {
                sum3 = sum3 + i;
            }
            Console.WriteLine("tong cac so tu chan tu 5 den 100 la : " + sum3);

            int sum4 = 1;
            Console.Write("nhap so n (tính n !) : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum4 = sum4 * i;
            }
            Console.WriteLine("n ! = " + sum4);

            Console.Write("nhap so n (check prime) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(x))
            {
                Console.WriteLine(x + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(x + " khong phai la so nguyen to");
            }

            Console.Write("nhap so n (check perfect) : ");
            int z = Convert.ToInt32(Console.ReadLine());
            if (IsPerfect(x))
            {
                Console.WriteLine(z + " la so hoan hao");
            }
            else
            {
                Console.WriteLine(z + " khong phai la so hoan hao");
            }


            Console.Write("day 10 so fibonaci : ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(fibonaci(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine("so fibonaci thu 13 la " + fibonaci(13));


            Console.Write("nhap so n : ");
            int q = Convert.ToInt32(Console.ReadLine());
            int qclone = q;
            int sum6 = 0;
            int sum7 = 0;
            int max = qclone % 10;
            while (qclone > 0)
            {
                sum6++;
                sum7 += qclone % 10;
                if(qclone%10 > max)
                {
                    max = qclone % 10;
                }
                qclone = qclone / 10;
            }
            Console.WriteLine($"Tong chu so cua {q} la: " + sum6);
            Console.WriteLine($"Tong cac chu so cua {q} la: " + sum7);
            Console.WriteLine("so lon nhat cua {q} la: " + max);


            Console.Write("nhap so n : ");
            int p = Convert.ToInt32(Console.ReadLine());
            string test = "";
            for(int i = 1; i <= p; i++)
            {
                test = test + i;
                if(test.Length >= p)
                {
                    Console.WriteLine($"so thu {p} la: " + test[p - 1]);
                    break;
                }
            }

            Console.Write("nhap so n <Phan tich N thanh cac thua so nguyen to> : ");
            int e = Convert.ToInt32(Console.ReadLine());
            ArrayList list = new ArrayList();
            
            for(int i = 2;i<=e; i++)
            {
                if(IsPrime(i) && e%i==0)
                {
                    list.Add(i);
                    e = e / i;
                    i = 1;
                }
            }
            String result = "";
            foreach(int i in list)
            {
                result = result + i + "*";
            }
            int len = result.Length;
            result=result.Substring(0,len-1);
            Console.WriteLine(result);

            Console.Write("nhap so a va b : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("So nguyen to giua a va b la : ");
            for (int i = a; i <=b;i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            int g = TimUocChungLonNhat(a, b);
            Console.WriteLine("Boi chung nho nhat cua a va b la " + (a*b)/g);
        } 


        public static int TimUocChungLonNhat(int a, int b)
        {
            // Chuyển đổi số âm thành số dương
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static int fibonaci(int x)
        {
            if (x <= 0)
            {
                throw new ArgumentException("Số Fibonacci phải là một số nguyên dương.");
            }

            if (x == 1 || x == 2)
            {
                return 1;
            }

            int[] arr = new int[x];
            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < x; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[x - 1];

        }

        public static bool IsPerfect(int number)
        { 
            if(number <= 0)
            {
                return false;
            }
            else
            {
                int sum = 0;
                for(int i = 1; i < number; i++)
                {
                    if(number % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if(sum == number)
                {
                    return true;
                }
            }
            return false;
        }
            public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Kiểm tra các số từ 2 đến căn bậc hai của number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void lession1()
        {
            Console.Write("Enter number: ");
            string x = Console.ReadLine();
            int n;
            bool check = IsInteger(x);
            if( check )
            {
                Console.WriteLine("DAY LA SO NGUYEN");
                n = Convert.ToInt32(x);
                if( checkOdd(n) )
                {
                    Console.WriteLine($"{n} la so le ");
                    if (n < 0)
                    {
                        Console.WriteLine("n la so le am");
                    }
                }
                else
                {
                    Console.WriteLine($"{n} la so chan ");
                    if(n > 0)
                    {
                        Console.WriteLine("n la so chan duong");
                    }
                }
                if(n > 0 )
                {
                    double a = Math.Sqrt(n);
                    if (IsInteger(a))
                    {
                        Console.WriteLine("day la so chinh phuong");
                    }
                    else
                    {
                        Console.WriteLine("day khong phai la so chinh phuong");
                    }
                }
                if(n>0 && n < 1000)
                {
                    int clone = n;
                    int sum = 0;
                    while(clone > 0 )
                    {
                        sum = sum +  ( (clone % 10) * (clone % 10) * (clone % 10)) ;
                        clone = clone / 10;
                    }
                    if(sum == n)
                    {
                        Console.WriteLine("day la so dac biet");
                    }
                    else
                    {
                        Console.WriteLine(sum);
                        Console.WriteLine("day khong phai la so dac biet");
                    }

                }
            }
            else
            {
                Console.WriteLine("DAY KHONG PHAI LA SO NGUYEN");
            }

        }

        public static bool IsInteger(double x) {
            return Math.Abs(x%1) < double.Epsilon;
        }

        public static bool checkOdd(int x) {
            return x % 2 == 1;
        }
            
        public static bool IsInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }
    }
}