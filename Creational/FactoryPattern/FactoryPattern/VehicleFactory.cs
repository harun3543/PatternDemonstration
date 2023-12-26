using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle( string type )
        {
            switch ( type )
            {
                case "car": return new Car();
                case "bicycle": return new Bicycle();
                default: throw new ArgumentException(" Invalid vehicle type ");
            }
        }
    }
}