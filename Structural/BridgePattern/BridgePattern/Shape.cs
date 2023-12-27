using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Shape
    {
        protected IDrawApi drawApi;

        protected Shape(IDrawApi drawApi)
        {
            this.drawApi = drawApi;
        }

        public abstract void Draw();
    }
}