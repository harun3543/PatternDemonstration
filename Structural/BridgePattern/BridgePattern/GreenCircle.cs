using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class GreenCircle : IDrawApi
    {
        public void DrawCircle(int radius)
        {
            Console.WriteLine($"Drawing Green Circle of radius {radius}");
        }
    }
}