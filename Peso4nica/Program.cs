using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx       //https://www.youtube.com/watch?v=pP24DbV0uCc&list=PLsFYKRZ3TlWy30IXw3R29mG6sgQlDMNFB&index=3

{
    internal class Program
    {

        static void Main(string[] args)
        {
            StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
            stockExchangeMonitor.PriceChangeHandler = ShowPrice;     // Методу ShowPrice назначается делегат PriceChangeHandler
            stockExchangeMonitor.Start();
        }
        
        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price is: {price}");
        }

    }
}
