using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    internal class Metods
    {
        static void PrintLine(string symbol, uint symbolCount)  // для первого
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }



        static int IndexOf(int[] array, int value)     //Второй
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }


        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }
            return myArray;
        }

        /// <summary>
        /// Это описание - сумма 2 чисел 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b) 
        { 
            return a + b;
        }

        static int Sum(int a, int b, int c) 
        {
            return a + b + c;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Input symbol:");   // Первый
            //string symbol = Console.ReadLine();  // надо использовать медот Console.ReadKey().KeyChar; если работает с CHAR

            //Console.WriteLine("Input quantity of symbols:");
            //uint symbolCount = uint.Parse(Console.ReadLine());

            //PrintLine(symbol, symbolCount);
            //Console.ReadLine();





            //int[] myArray = GetRandomArray(10, -11, 22);  //Второй

            //int result = IndexOf(myArray, 3);
            //Console.WriteLine(result);
            //Console.ReadLine();



            int result = Sum(4, 2);
            int result3 = Sum(4, 3, 5);
            Sum()
            Console.WriteLine();
        }
    }
}
