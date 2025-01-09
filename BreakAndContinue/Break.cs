using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAndContinue
{
    internal class Break
    {
        static void Main(string[] args)
        {
            //break - можно прерывать циклы, например получили нужную логику и надо выйти из цикла, например данные из внешнего источника

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 10)
            //    {
            //        break;   //как правило испольлзуется с проверкой IF 
            //    }
            //}
            //Console.ReadLine();




            //break example
            //for (int i = 0; i < 10; i++)
            //{
            //    string msg = Console.ReadLine();
            //    if (msg == "exit")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();





            //continue - позволяет прервать итерацию цикла но не выходить из него
            for (int i = 0; i < 11; i++)
            {
                if (i ==2) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
