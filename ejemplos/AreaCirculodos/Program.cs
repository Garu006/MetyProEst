namespace AreaCirculodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;
            Console.WriteLine("Ingrese el radio: ");
            radio = Double.Parse(Console.ReadLine());

            area = radio * radio * Math.PI;
            Console.WriteLine("El area del cirulo es: " + area);
        }
    }
}
