using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class PizzaDirector
    {
        private readonly IPizzaBuilder pizzaBuilder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public Pizza CreateVegetarianPizza()
        {
            return pizzaBuilder
                .SetDough("Whole Wheat")
                .SetSauce("Tomato")
                .Build();
        }

        public Pizza CreatePepperoniPizza()
        {
            return pizzaBuilder
                .SetDough("Thin Crust")
                .SetSauce("Spicy Tomato")
                .Build();
        }
    }
}