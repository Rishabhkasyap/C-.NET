using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class Loops
    {
        public void Loop1()
        {
            Console.WriteLine("program for loops");
            for(int step =1;step<=10;step++)
            {
                Console.WriteLine("step is " + step);
            }
            for(int step=10;step>=1;step--)
            {
                Console.WriteLine("step is "+step);
            }

        }
        public void table()
        {
            int num = 23;
            for (int step=1;step<=10;step++)
            {
                Console.WriteLine(" "+num*step);
            }
        }
        internal void fectorial()
        {
            int num = 7, r = 1;
            for(int step=num;step>1;step--)
            {
                r = r * step;
            }
            Console.WriteLine("Fectorial is " + r);
         }
        public void Reverse()
        {

            int num = 1234567891;
            String str = "";
            while(num !=0)
            {
                str = str + num % 10;
                num = num / 10;
            }
            Console.Write("Reverse is " + str);
        }
        internal void NestedLoop()

        {
            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
               
            }
            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6-i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    if(i%2!=0)
                    Console.Write(j + " ");
                    else
                        Console.Write( 6-j);
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                char ch1 = 'A';
                for (int j = 1; j <= 6 - i; j++)
                {
                   
                        Console.Write(ch1++);
                }
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();
            char ch = 'A';

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (j % 2 != 0)
                        Console.Write(ch + " ");   // add space after char
                    else
                    {
                        Console.Write((char)(ch + 32) + " ");  // stay on same line
                        ch++;
                    }
                }
                Console.WriteLine();  // newline after each row
            }
            Console.WriteLine();
            Console.WriteLine("=== Nested Loop Output ===");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                // Step 1: Print spaces
                for (int space = 1; space <= 5 - i; space++)
                {
                    Console.Write(" ");  // ✅ print space
                }

                // Step 2: Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");  // ✅ Write not WriteLine
                }

                Console.WriteLine();  // ✅ move to next line after each row
            } Console.WriteLine();

            int n = 5;

            // Upper Half (including middle)
            for (int i = 1; i <= n; i++)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower Half
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int n1 = 5;

            // Upper Half (including middle)
            for (int i = 1; i <= n1; i++)
            {
                // Print spaces
                for (int space = 1; space <= n1 - i; space++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower Half
            for (int i = n - 1; i >= 1; i--)
            {
                // Print spaces
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
