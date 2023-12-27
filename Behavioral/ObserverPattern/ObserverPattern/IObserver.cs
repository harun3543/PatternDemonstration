using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(string message);
    }
}