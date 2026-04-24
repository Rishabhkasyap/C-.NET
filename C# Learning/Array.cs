using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class Array
    {
        public void Array1()
        {
            int size;
            Console.WriteLine("Enter size of array");
            size = Convert.ToInt32((Console.ReadLine()));

            int [] array = new int [size];
            for(int i = 0; i < array.Length;i++)
            {
                Console.Write("Enter Item ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Elememnt are ");
            foreach(int i in array)// foreach is also use for print arr
            {
                Console.Write(" "+i);
            }
        }
    }
}
