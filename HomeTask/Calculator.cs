using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                 //Calculator
            //while (true)     // цикл который будет работать постоянно пока условие TRUE (бесконечно) 
            //{
            //    Console.Clear();   // метод для очистки консоли, чтобы не засорять при каждой работе цикла консоль (экран)
            //    double firstValue, secondValue;
            //    string action;

            //    try                // try и catch позволяет при парсировке в случае ошибки перейти в блок catch
            //    {
            //        Console.WriteLine("Input number 1");
            //        firstValue = double.Parse(Console.ReadLine());

            //        Console.WriteLine("Input number 2");
            //        secondValue= double.Parse(Console.ReadLine());
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Exception value can't be parse to number");
            //        Console.ReadLine();   // чтобы пользователь успел увидеть ошибку 
            //        continue;             // позволяет пропустить весь код который ниже и мы попадем в начало нашего цикла While
            //    }

            //    Console.WriteLine("Chose operation '+' '-' '*' '/'");
            //    action = Console.ReadLine();

            //    if (action == "+")
            //    {
            //        Console.WriteLine(firstValue + secondValue);
            //    }
            //    else if (action == "-")
            //    {
            //        Console.WriteLine(firstValue - secondValue);
            //    }
            //    else if (action == "*")
            //    {
            //        Console.WriteLine(firstValue * secondValue);
            //    }
            //    else if (action == "/")
            //    {
            //        if (secondValue == 0)
            //            Console.WriteLine(0);
            //        else
            //            Console.WriteLine(firstValue / secondValue);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error! You choose inknown action!");
            //    } 
            //    Console.ReadLine();

            //}




                                                   //Even and Odd values
            uint oddNumbersCount = 0;  //нечетные числа -uint так как это счетчики и они не могут быть отрицательными 
            uint evenNumbersCount = 0; //четные числа

            int oddNumberSum = 0;   //int так как сумма может быть отрицательной
            int evenNumberSum = 0;

            Console.WriteLine("Please input start value");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input last value of diapazone");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit) 
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumberSum += currentValue; //evenNumberSum = evenNumberSum+ currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumberSum = oddNumberSum+ currentValue;
                }
                currentValue++;

            }

            Console.WriteLine("quantity of odd numbers" + oddNumbersCount);
            Console.WriteLine("quantity of even numbers" + evenNumbersCount);
            Console.WriteLine("Sum of odd numbers" + oddNumberSum);
            Console.WriteLine("Sum of even numbers" + evenNumberSum);
            Console.ReadLine();
        }
    }
}
