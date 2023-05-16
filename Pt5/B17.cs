using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt5
{
    internal class B17
    {
        public class MyPoint
        {
            private int x;
            private int y;  
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public MyPoint()
            {
                x = 0;
                y = 0;
            }

            public MyPoint(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string? ToString()
            {
                return $"({X},{Y})";
            }
            public float Distance(int x, int y)
            {
                return (float)Math.Sqrt((X - x)* (X - x) + (Y-y) * (Y - y)); 
            }
            public float Distance(MyPoint p)
            {
                return (float)Math.Sqrt((X - p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y));
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("test 17.1: ");
            MyPoint p1 = new MyPoint(3, 0); MyPoint p2 = new MyPoint(0, 4);
            Console.WriteLine(p1.Distance(p2));
            Console.WriteLine(p1.Distance(5,6));
            Console.WriteLine("test 17.2: ");  
            MyCircle myCircle = new MyCircle(p1,1);
            
            Console.WriteLine(myCircle.GetArea());
        }

        public class MyCircle
        {
            private int x;
            public int X
            {
                get { return x; }
                set { x = value; }
            }

            MyPoint myPoint = new MyPoint();

            public MyCircle(int x, int y, int d)
            {
                myPoint.X = x;
                myPoint.Y = y;
                this.x = d;
            }
            public MyCircle(MyPoint p, int d) {
                this.myPoint = p;
                this.x = d;
            }
            public override string? ToString()
            {
                return $"(Hinh tron @ ({myPoint.X},{myPoint.Y}) ban kinh = {X}";
            }
            public float GetArea()
            {
                return (float) (this.X * this.X * 3.14);
            }
        }
    }
}
