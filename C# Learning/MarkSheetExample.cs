using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class MarkSheetExample
    {
        public void Question()
        {
            int physics_Marks = 54, Chemestry_Marks = 67, Math_Marks = 50, Hindi_Marks = 77, English_marks = 89;
            int Count = 0;
            if ((physics_Marks>=0 && physics_Marks<=100) && (Chemestry_Marks >= 0 && Chemestry_Marks <= 100) && (Math_Marks >= 0 && Math_Marks <= 100) && (Hindi_Marks >= 0 && Hindi_Marks <= 100) && (English_marks >= 0 && English_marks <= 100))
            {
                if(physics_Marks<30 )
                {
                    Count ++;
                }
                if(Chemestry_Marks<33)
                {
                    Count++;
                }
                if (Math_Marks < 33)
                {
                    Count++;
                }
                if (Hindi_Marks < 33)
                {
                    Count++;
                }
                if (English_marks < 33)
                {
                    Count++;
                }
                if (Count == 0)
                {
                    Console.WriteLine("Pass");
                }
                else if (Count == 1)
                {

                    Console.WriteLine("Supplimentry");
                }
                else
                {
                    Console.WriteLine("Fail");
                }



            }
            else
            {
                Console.WriteLine("Invalid Marks , It should be between 0 to 100");
            }
        }
    }
}
