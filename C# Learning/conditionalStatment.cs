using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class conditionalStatment
    {

        //Odd and Even using only if
        public void SimpleIf()
        {
            int num = 5;
            String result = "Odd";
            if (num % 2 == 0)
            {
                result = "Even";
            }
            Console.WriteLine(result);
        }
        //Write a program to calculate square
        //if number is even otherwise calculate cube?
        public void SimpleIfElse()
        {
            int num = 4;
            int result;
            if (num % 2 == 0)
            {
                result = num * num;
                Console.WriteLine("Square is " + result);
            }
            else
            {
                result = num * num * num;
                Console.WriteLine("Cube is " + result);

            }
        }
        public void NestedIfElse()
        {
            int year = 1000;
            if (year % 400 == 0)
            {
                Console.WriteLine("leap year");

            }
            else
            {
                if (year % 4 == 0)
                {
                    if (year % 100 != 0)
                    {
                        Console.WriteLine(" leap year");
                    }
                    else
                    {
                        Console.WriteLine("not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("not a leap year");
                }


            }

        }
        public void Ladder()
        {
            int year = 2000;

            if (year % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else if (year % 4 == 0 && year % 100 != 0) // Added year % 100
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year"); // Corrected result
            }
        }
        public void Multiple()
        {
            int num = 2000;
            if(num % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            if(num%2!=0)
            {
                Console.WriteLine("Odd");
            }
        }
    }
}

        
    


    

