using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StockMarket
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UpdatePrice()
        {
            foreach(var observer in observers)
            {
                observer.Update("Price increased by 0.5%");
            }
        }
    }
}