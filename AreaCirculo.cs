// See https://aka.ms/new-console-template for more information
double radio;
double area;
Console.WriteLine("Ingrese el radio: ");
radio = Double.Parse(Console.ReadLine());

area = radio * radio * Math.PI;
Console.WriteLine("El area del cirulo es: " + area);