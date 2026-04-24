using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class BoxingUnboxing
    {
       internal void Boxingfun()
        {
            int a = 10; 
            Object o;
            o = a;
            Console.WriteLine(o);

        }
        internal void UnBoxingfun2()
        {
            
            Object o = 10;
            int a = (int)o;
            Console.WriteLine(o);
        }
    }
}
