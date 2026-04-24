using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class SwitchCase
    {
       public void switch1()
        {
            int num = 4;
            switch (num  % 2)
            {
                case 0:
                    Console.WriteLine("even");
                    break;
                default:
                    Console.WriteLine("odd");
                    break;
            }
        }
        //vowel and consonant
        public void switch2()
        {
            char ch = 'b';
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
        }
    }
}
