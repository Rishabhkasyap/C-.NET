using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class Variables
    {
        static int y = 10;  // static variable
        int x = 10;         // instance variable

        public void Show()
        {
            int y = 50;  // local variable

            x = 20;      // ✅ allowed (inside instance method)

            Console.WriteLine("Local y: " + y);
            Console.WriteLine("Static y: " + Variables.y);
            Console.WriteLine("Instance x: " + x);
        }
       
            public static void fun1()
        {
            int x = 10; // static
            Console.WriteLine("Fun1 static x: " + x);
        }
        public void fun2()
        {
            int b = 20; //instance
            Console.WriteLine("Fun2 instance b: " + b);
        }
    
    }
}
