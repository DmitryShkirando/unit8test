using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionIFelse
{
    internal class IfElse
    {
        static void Main(string[] args)
        {
            //part1 IF Else




            //bool isInfected = false;

            //if (isInfected)
            //{
            //    Console.WriteLine("User is infected");
            //}
            //else
            //{
            //    Console.WriteLine("User is healthy");
            //}






            // example 2




            //int a;

            //Console.WriteLine("Inpute a value");
            //a = int.Parse(Console.ReadLine());

            //if (a == 5)
            //{
            //    Console.WriteLine("a is equal 5");
            //}

            //else 
            //{
            //    Console.WriteLine("a is not equal 5 it is " + a);
            //}






            // ДЗ1 проверка числа на четность



            //int t;
            //Console.WriteLine("Input even number");
            //t = int.Parse(Console.ReadLine());
            //if (t % 2 == 0)              // a % 10 == 0 проверка числа на десятичное число
            //{
            //    Console.WriteLine("You inputed correct - EVEN number");
            //}
            //else
            //{
            //    Console.WriteLine("You inputed incorrect - ODD number");
            //}





            // PART 3 SWITCH тоже самое что и IF ELSE только чуть другой подход ()



            int r = int.Parse(Console.ReadLine());

            switch (r)
            {
                case 1:
                case 2:
                    Console.WriteLine("You inputed value 1 or 2");
                    break;
                default:
                    Console.WriteLine("ysdisd");
                    break;
            }

            // just example with text
            Console.WriteLine("input any words or Plus or Minus");
            string y = Console.ReadLine();
            switch (y)
            {
                case "+":
                    Console.WriteLine("You inputed plus");
                    break;
                case "-":
                    Console.WriteLine("You inputed minus");
                    break;
                default:
                    Console.WriteLine("You inputed something else");
                    break;
            }






            Console.ReadLine();

            /*
             * && сокращенное И
             * || сокращенное ИЛИ
             * & - И
             * | - ИЛИ
             * ! - НЕ (унарный)
             * 
             */
        }
    }
}
