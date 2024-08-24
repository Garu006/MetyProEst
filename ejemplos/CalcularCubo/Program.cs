namespace CalcularCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, resultado;
            Console.WriteLine("Ingrese el numero: ");
            num1 = int.Parse(Console.ReadLine());
            resultado = num1 * num1 * num1;
            Console.WriteLine("El numero " + num1 + "elevado al cubo es: " + resultado);
        }
    }
}
