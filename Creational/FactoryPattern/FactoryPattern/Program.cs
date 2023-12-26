// See https://aka.ms/new-console-template for more information

using FactoryPattern;

IVehicle bicycle, car;
VehicleFactory factory = new VehicleFactory();

bicycle = factory.CreateVehicle("bicycle");
bicycle.Drive();

car = factory.CreateVehicle("car");
car.Drive();


