namespace Pt5
{
    internal class B1
    {
        class SOHOC
        {
            private float number1, number2;

            public SOHOC()
            {
            }

            public SOHOC(float number1, float number2)
            {
                Number1 = number1;
                Number2 = number2;
            }

            public float Number1
            {
                get => number1;
                set => number1 = value; 
            }
            public float Number2
            {
                get => number2;
                set => number2 = value;
            }

            public void InputInfo()
            {
                Console.Write("Enter the number 1: ");
                number1 =float.Parse(Console.ReadLine());
                Console.Write("Enter the number 2: ");
                number2 = float.Parse(Console.ReadLine());

            }
            public void PrintInfo() { 
                Console.Write($"Number 1: {number1} Number 2: {number2}");
            }

            public float Addition() { 
                return number1 + number2;
            }

            public float Subtract() {
                return (number1 - number2);
            }

            public float Multi() { 
                return number2 * number1;
            }

            public float Division()
            {
                return number1 / number2;
            }
        }
    }
}