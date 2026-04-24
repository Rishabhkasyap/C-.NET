using System;
using System.Threading.Tasks.Dataflow;

namespace C__Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Option:");
            Console.WriteLine("1. Operations");
            Console.WriteLine("2. Simple Interest");
            Console.WriteLine("3. Variables1");
            Console.WriteLine("4. Variables2");
            Console.WriteLine("5. Swap Program");
            Console.WriteLine("6. Area of circle");
            Console.WriteLine("7. Area of Trangle");
            Console.WriteLine("8. Feet into Inch");
            Console.WriteLine("9. Inch into Feet");
            Console.WriteLine("10. Reverse a Three Digit Number");
            Console.WriteLine("11. Boxing And UnBoxing");
            Console.WriteLine("12. Data Type");
            Console.WriteLine("13. Diffrence of date in year");
            Console.WriteLine("14. SumDateDigit");
            Console.WriteLine("15. conditional Satatment");
            Console.WriteLine("16. MarkSheetExample");
            Console.WriteLine("17. SwitchCase");
            Console.WriteLine("18. Loops");
            Console.WriteLine("19. BreakAndContinue");
            Console.WriteLine("20. Array");
            Console.WriteLine("21. ");
            Console.WriteLine("22. ");
            Console.WriteLine("23. ");
            Console.WriteLine("24. ");
            Console.WriteLine("25. ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Oprations op = new Oprations();
                op.Accept();
                op.Add();
                op.Sub();
                op.Mul();
                op.Div();
            }
            else if (choice == 2)
            {
                SimpleIntrest si = new SimpleIntrest();
                si.calSI();
            }
            else if (choice == 3)
            {
                Variables obj = new Variables();  // create object
                obj.Show();                       // call method


            }
            else if (choice == 4)
            {
                Variables.fun1();
                Variables obj = new Variables();  // ✅ create object
                obj.fun2();
            }
            else if (choice == 5)
            {
                swap obj = new swap();
                obj.swapprogram();
            }
            else if (choice == 6)//Area of circle
            {
                AreaOfCircleAndTrangle obj = new AreaOfCircleAndTrangle();
                obj.AreaOfCircle();
            }
            else if (choice == 7)
            {
                AreaOfCircleAndTrangle obj = new AreaOfCircleAndTrangle();
                obj.AreaOfTrangle();
            }
            else if (choice == 8)
            {
                AreaOfCircleAndTrangle obj = new AreaOfCircleAndTrangle();
                obj.FeetToInch();

            }
            else if (choice == 9)
            {
                AreaOfCircleAndTrangle obj = new AreaOfCircleAndTrangle();
                obj.InchToFeet();

            }
            else if (choice == 10)
            {
                AreaOfCircleAndTrangle obj = new AreaOfCircleAndTrangle();
                obj.ReverseThreeDigit();

            }
            else if (choice == 11)
            {
                BoxingUnboxing obj = new BoxingUnboxing();
                obj.Boxingfun();
                obj.UnBoxingfun2();

            }
            else if (choice == 12)
            {
                DataType obj = new DataType();
                obj.PrimitiveDataType();
                obj.DerivedDataType();


            }
            else if (choice == 13)
            {
                DateDiff obj = new DateDiff();
                obj.dateDiff();



            }
            else if (choice == 14)
            {
                SumDateDigit obj = new SumDateDigit();
                obj.DateOfBirth();
                obj.loops();


            }
            else if (choice == 15)
            {
               conditionalStatment obj = new conditionalStatment();
                obj.SimpleIf();
                obj.SimpleIfElse();
                obj.NestedIfElse();
                obj.Ladder();
                obj.Multiple();
            }
            else if (choice == 16)
            {
                //WAP to display the subject mark of the student
                //which will be entered by the user's if the entered subject
                //mark is eligible for grace then display mark including grace
                //mark otherwise actual mark will display.
                MarkSheetExample obj = new MarkSheetExample();
                obj.Question();



            }
            else if (choice == 17)
            {
                SwitchCase obj = new SwitchCase();
                obj.switch1();
                obj.switch2();



            }
            else if (choice == 18)
            {
                Loops obj = new Loops();
                obj.Loop1();
                obj.table();
                obj.fectorial();
                obj.Reverse();
                obj.NestedLoop();



            }
            
            else if (choice == 19)
            {

                BreakAndContinue obj = new BreakAndContinue();
                obj.Break();
                obj.Continue();
                obj.Binary();
                obj.NumberToBinary();


            }
            else if (choice == 20)
            {
               Array obj    = new Array();
                obj.Array1();



            }
            else if (choice == 21)
            {
               



            }
            else if (choice == 22)
            {



            }
            else if (choice == 23)
            {
                



            }
            else if (choice == 24)
            {
                



            }


            else
            {
                Console.WriteLine("Invalid choice");
            }

            Console.ReadLine();
        }
    }
}