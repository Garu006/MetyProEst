namespace RaizCuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            double raiz;
            Console.WriteLine("Ingrese el numero: ");
            num1 = int.Parse(Console.ReadLine());
            raiz=Math.Sqrt(num1);
            Console.WriteLine("La raiz cuadrada de: " + num1 + " es: " + raiz);
        }
    }
}
