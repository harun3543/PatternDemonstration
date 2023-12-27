using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius)
        {
            Console.WriteLine($"Drawing Red Circle of radius {radius}");
        }
    }
}