using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCheck
{
    internal class OnlineCheck
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 30 },
            { "Bob", 25 }
        };
            ages["Charlie"] = 35;

            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
