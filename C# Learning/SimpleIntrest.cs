using System;

namespace C__Learning
{
    internal class SimpleIntrest
    {
        float p, r, t, si;

        internal void calSI()
        {
            p = 12000;
            r = 2.2F;
            t = 4.5F;

            si = (p * r * t) / 100;

            Console.WriteLine($"Result is {si}"); 
        }
    }
}