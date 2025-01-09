using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWords
{
    internal class Params
    {
        static int Sum(string message, params int[] parameters)
        {
            int result = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }



        static void Foo(params object[] parameters)
        {
            string message = "Type of data {0} , value is {1}";

            foreach (object item in parameters) 
            {
                Console.WriteLine(message, item.GetType(), item);
            }

        }


        static void Main(string[] args)
        {
            int result = Sum("Hello - sum is ", 4, 5, 2, 34);
            Console.WriteLine(result);


            Foo("Tedt", 't', 434, 3.5f, true);

            Console.ReadLine();
        }
    }
}
