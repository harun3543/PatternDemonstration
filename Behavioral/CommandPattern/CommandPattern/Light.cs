using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public void TurnOn() => Console.WriteLine("Light is on.");
        public void TurnOff() => Console.WriteLine("Light is off");
    }
}