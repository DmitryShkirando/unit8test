using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateEx      

{
    public class StockExchangeMonitor
    {
        public delegate void PriceChange(int currentPrice);

        public PriceChange PriceChangeHandler { get; set; }       // Свойство для хранения экземпляра делегата

        public void Start()
        {
            while (true) 
            {
                int bankOfAmerica = (new Random()).Next(100);

                PriceChangeHandler(bankOfAmerica);

                Thread.Sleep(2000);
            }
        }
    }  
}
