using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LongDT
{
    internal class Oop1
    {
        class Animal
        {
            //fields:
            private int id;
            public string name;
            public float age;
            private int[] rate;

            // property:
            public int ID
            {
                get => id;
                set => id = value;       
            }

            public int[] Rate
            {
                get => rate;
                set => rate = value;
            }
            //methods:

            public void Move() {
                Console.WriteLine("Swim,run,fly,....");
            }
            public void InputInfo() {
                Console.WriteLine("Input id: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Input name: ");
                name = Console.ReadLine();
                Console.WriteLine("Input age: ");
                age = float.Parse(Console.ReadLine());
            }

            //indexer: truy cap vao cac thanh phan cua truong mang thong uqa chinh ban than doi tuong
            public int this[int i] { 
                get => rate[i];
                set => rate[i] = value;
            }

            public Animal()
            {
                
            }

            public Animal(int id, string name, float age, int[] rate)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.rate = rate;
            }
        }

        class Cat : Animal
        {
            String color;
            public Cat()
            {
                
            }

            public Cat(int id, string name, float age,int[] rate, string color): base(id, name, age, rate)
            {
                this.color = color;
            }
            public new void InputInfo()
            {
                base.InputInfo();
                Console.WriteLine("Input color: ");
                color = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            //OOP
            Animal cat = new Animal();
            cat.Move();
            cat.InputInfo();
            cat.Rate = new int[3];
            cat.Rate[0] = 1;
            cat.Rate[1] = 2;
            cat.Rate[2] = 3;

            foreach (var item in cat.Rate)
            {
                Console.WriteLine(item);
            }

            cat[0] = 2;
            cat[1] = 57;
            cat[2] = 90;
            foreach (var item in cat.Rate)
            {
                Console.WriteLine(item);
            }
        }
    }
}
