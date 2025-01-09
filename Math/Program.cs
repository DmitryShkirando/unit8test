using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* тернарный оператор

              [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
            */




            //int a = 0;
            //a++; //это унарная операция так как операнд только один
            //int b = 0;
            //int c = a + b; // тут плюс уже бинарный





            //bool accessAllowed;
            //string storedPassword = "qwerty";
            //string enteredPaswsord = Console.ReadLine();

            //accessAllowed = enteredPaswsord == storedPassword ? true : false;

            //Console.WriteLine(accessAllowed);
            //Console.ReadLine();





            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 11 : inputData; // в скобки взято только для визульного понимания, можно без них

            Console.WriteLine(outputData);
            Console.ReadLine();
        }
    }
}
