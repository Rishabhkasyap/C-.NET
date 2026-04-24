using System;
using System.Collections.Generic;
using System.Text;

namespace C__Learning
{
    internal class AreaOfCircleAndTrangle
    {
       internal void AreaOfCircle()
        {
            Console.WriteLine("Enter Redius of circule: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = Math.PI* radius * radius;
            Console.WriteLine($"Area of Circle : {circleArea:F2}");
        }
        internal void AreaOfTrangle()
        {
            Console.WriteLine("/n Enter base of Triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter Hight of Tringle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double triArea = 0.5 * b * h;
            Console.WriteLine($"Area of Tringle: {triArea}");

        }
        internal void FeetToInch()
        {
            // Feet to Inches
            Console.Write("Enter Feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet = {feet * 12} inches");
        }
        internal void InchToFeet()
        {
            // Inches to Feet
            Console.Write("\nEnter Inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{inches} inches = {inches / 12:F2} feet");
        }
        internal void ReverseThreeDigit()
        {
            Console.Write("Enter a three-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine()); // Example: 123

            int first = num / 100;        // 1
            int second = (num / 10) % 10; // 2
            int third = num % 10;         // 3

            int reversed = (third * 100) + (second * 10) + first;
            Console.WriteLine($"Reversed Number: {reversed}");
        }
    }
}
