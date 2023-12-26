// See https://aka.ms/new-console-template for more information

using BuilderPattern;

Pizza pizza = new Pizza();
PizzaBuilder builder = new PizzaBuilder();
PizzaDirector director = new PizzaDirector(builder);

pizza = director.CreateVegetarianPizza();
Console.WriteLine(pizza.Sauce);
Console.WriteLine(pizza.Dough);

Console.WriteLine("-----------------------------------");

pizza = director.CreatePepperoniPizza();
Console.WriteLine(pizza.Sauce);
Console.WriteLine(pizza.Dough);