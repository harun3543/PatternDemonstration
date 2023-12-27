// See https://aka.ms/new-console-template for more information

using BridgePattern;

RedCircle redCircle = new RedCircle();
Circle circle = new Circle( 55, redCircle );
circle.Draw();

GreenCircle greenCircle = new GreenCircle();
Circle circle1 = new Circle( 100, greenCircle);
circle1.Draw();
