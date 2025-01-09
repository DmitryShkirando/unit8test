using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace null_question
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            //string str = null;

            //string result = str ?? "default string";

            //Console.WriteLine("Quantity of symbols in line is " + result.Length);
            //Console.ReadLine();





            //string str = null;
            //str ??= "default string";  // для того чтобы работало надо 
            //Console.WriteLine("Quantity of symbols in line is " + str.Length);
            //Console.ReadLine();



            /*
             *  оператор условного null     ?.
             * 
             */


            int[] myArray = GetArray();

            Console.WriteLine("Sum of array element is " + (myArray?.Sum() ?? 0)); //прежде чем будет обращение к массиву произойдет проверка на null
            Console.ReadLine();


        }
    }
}
