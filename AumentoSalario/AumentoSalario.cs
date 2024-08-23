// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese el nombre del trabajador: ");
string name = Console.ReadLine();
Console.WriteLine("Ingrese el cargod el trabajador: ");
string cargo = Console.ReadLine();
Console.WriteLine("Ingrese el salario del trabajador: ");
double salario = Convert.ToDouble(Console.ReadLine());

double aumento = salario * 0.10;
double Nuevo_Salario = salario + aumento;

Console.WriteLine("\nDatos del trabajador: ");
Console.WriteLine($"Nombre: {name}");
Console.WriteLine($"Cargo: {cargo}");
Console.WriteLine($"Salario: {salario}");
Console.WriteLine($"Aumento: {aumento}");
Console.WriteLine($"Nuevo salario: {Nuevo_Salario}");