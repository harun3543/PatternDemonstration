using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Stock : IObserver
    {
        private string symbol;
        private double price;
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{symbol} - Price: {price} - {message}");
        }
    }
}