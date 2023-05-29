using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    interface ICalculate
    {
        double Area();

    }
    class Rectangle : ICalculate
    {
        float height;
        float width;


        public float Height { get => height; set => height = value; }
        public float Width { get => Width; set => Width = value; }
        public Rectangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public double Area()
        {
            return height * width;
        }
    }
    internal class IsAndAs
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3.5f, 4);
            ICalculate calculate;
            if(rectangle is ICalculate)
            {
                calculate = rectangle as ICalculate;
                Console.WriteLine($"oke 1");
            }
            else
            {
                Console.WriteLine("oke 2");
            }
        }
    }
}
