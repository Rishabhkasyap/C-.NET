using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    //Write a program to calculate the
    //difference of two dates in the year, a date should be assined
    //DDMMYYYY 1205216 13062016 O/P 2019 -2016 = 3
    internal class DateDiff
    {
        public void dateDiff()
        {
            String date1 = "12052016";
            String date2 = "13062019";
            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);
            int y1 = d1 % 1000;
            int y2 = d2 % 1000;
            Console.WriteLine("Diffrence of date in year {0}", y2 - y1);
        }
    }
}
