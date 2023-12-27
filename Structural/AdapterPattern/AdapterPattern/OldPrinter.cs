using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class OldPrinter
    {
        public void PowerOn() => Console.WriteLine("Old printer powered on");
        public void PowerOff() => Console.WriteLine("Old printer powered off");
    }
}