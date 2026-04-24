using System;

namespace C__Learning
{
    internal class Oprations
    {
        int a, b, c;

        public void Accept()
        {
            Console.WriteLine("Enter First Number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void Add()
        {
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }

        public void Sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction: " + c);
        }

        public void Mul()
        {
            c = a * b;
            Console.WriteLine("Multiplication: " + c);
        }

        public void Div()
        {
            if (b != 0)
            {
                c = a / b;
                Console.WriteLine("Division: " + c);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
}