// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

int num1, num2, num3;
Console.WriteLine("Escriba un numero: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba el segundo numero: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba un numero: ");
num3 = int.Parse(Console.ReadLine());

int mayor;
mayor = num1;
if(mayor<num2)  mayor = num2;
if (mayor<num3) mayor = num3;

Console.WriteLine("El mayor de los tres numeros es: " + mayor);
Console.ReadLine();
