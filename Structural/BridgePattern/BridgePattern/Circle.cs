using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius, IDrawApi drawApi) : base( drawApi )
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            drawApi.DrawCircle( radius );
        }
    }
}