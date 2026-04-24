using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class BreakAndContinue
    {
        public void Break()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.Write(i);
            }
        }

        public void Continue()
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.Write(i);
            }
        }
        public void Binary()
        {
            Console.WriteLine();
            int num = 9;
            String data = "";
            while (num != 0)
            {
                data = num % 2 + data;
                num = (int)(num / 2);
            }
            Console.WriteLine(data);
        }
        public void NumberToBinary()
        {
            int num = 1001;
            int b,s=0, e = 0;
            while (num != 0)
            {
                b = num % 10;
                s = s + b*(int) Math.Pow(2, e);
                num = (int)(num / 10);
                e++;

            }
            Console.WriteLine(s);
        }
    }
}
