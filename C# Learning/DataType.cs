using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class DataType
    {
        public void PrimitiveDataType()
        {
            int a = 10; 
            byte bt = 2; // 1 byte
            float b = 24.4F;
            double c = 23345.2;
            bool d = false;
            char ch = 'a';
            Console.WriteLine("a={0}, b={2}, c={2}, d={3}, ch={4}, bt={5}", a, b,bt, c, d, ch);


        }
        public void DerivedDataType()
        {
            Int16 a = 10;
            Byte bt = 2;
            Double b = 23.45F;
            Boolean c = false;
            Char ch = 'a';
            String s = "Rishabh";
            Object o = "12345";
            Console.WriteLine("a={0}, b={2}, c={2}, d={3}, ch={4}, bt={5}", a, b, b, c, ch, o,s);


        }
        public void dateDiff()
        {
            String date1 = "12052016";
            String date2 = "13062019";
            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);
            int y1 = d1 % 1000;
            int y2 = d2 % 1000;
            Console.WriteLine("Diffrence of date in year {0}",y2 - y1);
        }
    }
}
