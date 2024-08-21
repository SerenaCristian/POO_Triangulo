using System;
using Triangulo;

namespace Aplicacao
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string sep = new string('-', 50);

            ClasseTriangulo x = new ClasseTriangulo();
            ClasseTriangulo y = new ClasseTriangulo();

            Console.WriteLine("Programa Triângulo");
            Console.WriteLine(sep);
            Console.WriteLine("Digite as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área do triângulo X: {areaX:F2}");
            Console.WriteLine($"Área do triângulo Y: {areaY:F2}");

            if (areaX > areaY)
            {
                Console.WriteLine("Triângulo X é maior");
            }
            else
            {
                Console.WriteLine("Triângulo Y é maior");
            }
        }
    }
}

