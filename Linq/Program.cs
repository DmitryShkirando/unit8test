using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }

    class City
    {
        public string Name { get; set; }

        public string Country { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Исходные данные
            List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30, City = "New York" },
            new Person { Name = "Jane", Age = 25, City = "London" },
            new Person { Name = "Tom", Age = 35, City = "New York" },
            new Person { Name = "Lucy", Age = 20, City = "Paris" },
            new Person { Name = "Anna", Age = 28, City = "London" },
        };

            // Фильтрация (Where)
            var filtered = people.Where(p => p.Age > 25);
            Console.WriteLine("Filtration (Age > 25):");
            foreach (var person in filtered)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            // Проекция (Select)
            var projected = people.Select(p => new { p.Name, AgeInTenYears = p.Age + 10 });
            Console.WriteLine("Proection (Age in 10 years):");
            foreach (var person in projected)
            {
                Console.WriteLine($"{person.Name} - {person.AgeInTenYears}");
            }

            // Упорядочение (OrderBy, ThenBy)
            var ordered = people.OrderBy(p => p.City).ThenBy(p => p.Name);
            Console.WriteLine("Ordering (City, then Name):");
            foreach (var person in ordered)
            {
                Console.WriteLine($"{person.City} - {person.Name}");
            }

            // Группировка (GroupBy)
            var grouped = people.GroupBy(p => p.City);
            Console.WriteLine("Grupping (по City):");
            foreach (var group in grouped)
            {
                Console.WriteLine($"\nCity: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }

            // Агрегация (Count, Sum, Average, Min, Max)
            int count = people.Count();
            int sumAge = people.Sum(p => p.Age);
            double averageAge = people.Average(p => p.Age);
            int minAge = people.Min(p => p.Age);
            int maxAge = people.Max(p => p.Age);

            Console.WriteLine("\nAgregation:");
            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Sum of Ages: {sumAge}");
            Console.WriteLine($"Average Age: {averageAge}");
            Console.WriteLine($"Min Age: {minAge}");
            Console.WriteLine($"Max Age: {maxAge}");

            Console.WriteLine("#####################");
            Console.WriteLine("#####################");
            Console.WriteLine("#####################");
            Console.WriteLine("#####################");
            Console.WriteLine("#####################");

            //Объединение(Join)
            List<City> cities = new List<City>
        {
            new City { Name = "New York", Country = "USA" },
            new City { Name = "London", Country = "UK" },
            new City { Name = "Paris", Country = "France" }
        };

            var joined = people.Join(cities,
                                     person => person.City,
                                     city => city.Name,
                                     (person, city) => new { person.Name, person.Age, City = city.Name, city.Country });

            Console.WriteLine("\nОбъединение (Join):");
            foreach (var item in joined)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.City} - {item.Country}");
            }

            // Групповое объединение (GroupJoin)
            var groupJoin = cities.GroupJoin(people,
                                             city => city.Name,
                                             person => person.City,
                                             (city, persons) => new { City = city.Name, Country = city.Country, Persons = persons });

            Console.WriteLine("\nГрупповое объединение (GroupJoin):");
            foreach (var group in groupJoin)
            {
                Console.WriteLine($"{group.City} - {group.Country}");
                foreach (var person in group.Persons)
                {
                    Console.WriteLine($"  {person.Name} - {person.Age}");
                }
            }

            Console.ReadLine();

        }
    }
}
