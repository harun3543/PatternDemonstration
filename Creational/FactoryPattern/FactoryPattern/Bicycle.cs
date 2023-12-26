using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a bicycle");
        }
    }
}