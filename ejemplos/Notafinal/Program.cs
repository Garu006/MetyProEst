
using Notafinal.clases;

namespace EstudianteNotaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 2");
            Nota nota = new Nota();
            int nota1 = 0;
            int nota2 = 0, notaFinal;
            int nota3 = 0;

            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercena nota: ");
            nota3 = int.Parse(Console.ReadLine());

            nota.Nota1 = nota1;
            nota.Nota2 = nota2;
            nota.Nota3 = nota3;

            notaFinal = nota.calcularNota();


            Console.WriteLine($"{notaFinal}");
        }
    }
}
