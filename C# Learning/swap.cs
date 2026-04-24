using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class swap
    {
        static int a = 5, b = 10;
       internal void swapprogram()
        {
            int temp = a;
            a = b;
            b= temp;
            Console.WriteLine("Value of a={0} and b={1}", a, b);
        }
    }
}
