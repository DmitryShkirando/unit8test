using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int x = 0;    //Поменяй Х и Y местамаи 0 и 1 и будут разные исключения
            //int y = 1;

            //try
            //{
            //    int result1 = x / y;
            //    int result2 = y / x;
            //}
            //catch (DivideByZeroException) when (y == 0)
            //{
            //    Console.WriteLine("yNot should by  Y = 0");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




            try
            {
                ValidateAge(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorect value");
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Should be more");
            }
        }
    
    }
}
