using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeArraySize
{
    internal class Program
    {
        static void Resize<T>(ref T[] array, int newSize)   //смена размера массива
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;  //ключевое - заменяем ссылку старого массива на ссылку нового массива, благодоря REF
        }




        static void Insert(ref int[] array, int newValue, int index)    //дз 2 - метод для добавления в начало, конец и по указанному массиву
        {
            int [] newArray = new int[array.Length + 1];
            newArray[index] = newValue;
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array= newArray;
        }

        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }

        static void AddLast(ref int[] array, int value)
        {
            Insert(ref array, value, array.Length);
        }



        static void RemoveAt(ref int[] array, int index)  // 3 дз - удаление элементов
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        static void RemoveFirst(ref int[] array)
        {
            RemoveAt(ref array, 0);
        }

        static void RemoveLast(ref int[] array)
        {
            RemoveAt(ref array, array.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2 };
            //string[] strArray = {"test", "hello", "world" };
            //Resize(ref strArray, 16);

            Insert(ref myArray, -5, 2);
            RemoveAt(ref myArray, 1);

            Console.ReadLine();
        }
    }
}
