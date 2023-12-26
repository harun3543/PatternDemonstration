using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PizzaBuilder : IPizzaBuilder
    {
        
        private Pizza pizza = new Pizza();

        public IPizzaBuilder SetDough(string dough)
        {
            pizza.Dough = dough;
            return this;
        }

        public IPizzaBuilder SetSauce(string sauce)
        {
            pizza.Sauce = sauce;
            return this;
        }
        public Pizza Build()
        {
            return pizza;
        }
        
    }
}