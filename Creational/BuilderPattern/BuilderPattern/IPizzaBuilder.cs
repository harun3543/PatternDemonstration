using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetDough(string dough);
        IPizzaBuilder SetSauce(string sauce);
        Pizza Build();
    }
}