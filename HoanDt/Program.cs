namespace HoanDt
{
    static class Utils
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Sub(this int a, int b) { return a - b; }
    }
    public class Location
    {
        private int x;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 2;
            int r = Utils.Add(x, y);
            Console.WriteLine(r);
            r = x.Sub(y);
            

            Shape p = new Circle();
            p.Display();
            p.Draw();
            p = new Rectange();
            p.Draw();
            p.Display();
            p.Print();

            Rectange rect = new Rectange(); 
            rect.Print();
        }

        public class Rectange : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Display Rectangle");
            }
            public override void Display()
            {
                Console.WriteLine("Display rectangle"); ;
            }
            public new void Print()
            {
                Console.WriteLine("Print Rectangle");
            }
        }
        public class Circle : Shape
        {
            public override void Display()
            {
                Console.WriteLine("Drawing a circle");
            }

            public override void Draw()
            {
                Console.WriteLine("Display Circle");
            }
        }
        public abstract class Shape{
            public int Height {get; set;}
            public int Width { get; set;}

            //Virtual method
            public virtual void Draw()
            {
                Console.WriteLine("Performing base class Drawing tasks");
            }
            public void Print()
            {
                Console.WriteLine("Perfoming base class Printing tasks");
            }

            // Abstract method
            public abstract void Display();
        }
    }
}