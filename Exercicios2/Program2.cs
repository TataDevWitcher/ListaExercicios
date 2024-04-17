using System;
using System.Globalization;

namespace Exercicio2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Área de um círculo*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            Console.WriteLine("Entre com o raio do círculo:");
            double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double areaCirculo = pi * (Math.Pow(raioCirculo, 2));

            Console.WriteLine($"A área do círculo é: {areaCirculo:F4}");
        }
    }
}