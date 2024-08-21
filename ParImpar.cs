// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un numero: ");
int num = int.Parse(Console.ReadLine());
if(num%2==0)
{
    Console.WriteLine("Este numero " + num + " es par");
}
else
{
    Console.WriteLine("Este numero " + num + " no es par");
}

