using System;
using System.Globalization;

namespace Exercicios6
{
    class Program6
    {
        static void Main (string[] args)
        {
            Console.WriteLine("*Três valores - Valor total*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            double valorA, valorB, valorC;

            Console.WriteLine("Entre com três valores com ponto flutuante utilizando o . (Separados cada um por um espaço):");
            string[] valores = Console.ReadLine().Split(' ');

            valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (valorA * valorC) / 2.0;
            Console.WriteLine($"Área do triângulo retângulo que tem A por base e C por altura: {areaTriangulo:F3}");
            //Console.WriteLine("Area do triângulo retângulo que tem A por base e C por altura: " + areaTriangulo.ToString("F2", CultureInfo.InvariantCulture));

            double pi = 3.14159;
            double areaCirculo = pi * Math.Pow(valorC, 2.0);
            Console.WriteLine($"Área do círculo de raio C: {areaCirculo:F3}");

            double areaTrapezio = (valorA + valorB) / 2.0 * valorC;
            Console.WriteLine($"Área do trapézio que tem A e B por bases e C por altura: {areaTrapezio:F3}");

            double areaQuadrado = Math.Pow(2.0, valorB);
            Console.WriteLine($"Área do quadrado que tem lado B: {areaQuadrado:F3}");

            double areaRetangulo = valorA * valorB;
            Console.WriteLine($"Área do retângulo que tem lados A e B: {areaRetangulo:F3}");
        }
    }

}