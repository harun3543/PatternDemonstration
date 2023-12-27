// See https://aka.ms/new-console-template for more information

using System.Windows.Input;
using CommandPattern;

Light light = new Light();
Light bedroomLight = new Light();
Light kitchenLight = new Light();

LightOnCommand lightOnCommand = new LightOnCommand(light);
LightOffCommand lightOffCommand = new LightOffCommand(light);
LightOnCommand bedroomLightOnCommand = new LightOnCommand(bedroomLight);
LightOffCommand bedroomLightOffCommand = new LightOffCommand(bedroomLight);


lightOnCommand.Execute();
lightOffCommand.Execute();
Console.WriteLine("-------------------------------");
bedroomLightOnCommand.Execute();
bedroomLightOffCommand.Execute();

