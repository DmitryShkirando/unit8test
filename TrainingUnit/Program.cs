using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Sum(int x, int y, int c) => x + y + c;
            //Console.WriteLine(Sum(5, 3, 5)); // Выведет 8


            //List<int> numbers = new List<int> { 1, 4, 6, 8, 3, 9 };
            //var filtered = numbers.Where(n => n > 5).ToList();
            //Console.WriteLine(string.Join(", ", filtered)); // Выведет: 6, 8, 9


            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            var upperNames = names.Select(name => name.ToUpper()).ToList();
            Console.WriteLine(string.Join(", ", upperNames)); // Выведет: ALICE, BOB, CHARLIE



            List<int> numbers = new List<int> { 4, 1, 7, 3, 8 };
            var ascending = numbers.OrderBy(n => n).ToList(); // По возрастанию
            var descending = numbers.OrderByDescending(n => n).ToList(); // По убыванию

            Console.WriteLine(string.Join(", ", ascending)); // Выведет: 1, 3, 4, 7, 8
            Console.WriteLine(string.Join(", ", descending)); // Выведет: 8, 7, 4, 3, 1



            List<int> numbers2 = new List<int> { 1, 4, 4, 7, 7, 8 };
            var uniqueNumbers = numbers2.Distinct().ToList();
            Console.WriteLine(string.Join(", ", uniqueNumbers)); // Выведет: 1, 4, 7, 8



            List<int> numbers3 = new List<int> { 1, 4, 6, 8 };
            int firstNumber = numbers3.FirstOrDefault(n => n > 5); // Найдет 6
            bool hasLargeNumbers = numbers3.Any(n => n > 10); // Вернет false

            Console.WriteLine(firstNumber); // 6
            Console.WriteLine(hasLargeNumbers); // False



            List<int> numbers4 = new List<int> { 1, 4, 11, 8, 3, 9 };
            var filtered = numbers4.Where(n => n > 5).ToList();

            // Перебор и вывод каждого элемента отдельно
            foreach (var number in filtered)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("It is first commit");

            Console.ReadLine();
        }
    }
}
