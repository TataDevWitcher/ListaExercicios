using System;
using System.Globalization;

namespace Exercicio3 
{
    class Program3
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("*Diferença de produtos*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            Console.WriteLine("Entre com o valor A:");
            double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor B:");
            double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor C:");
            double valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o valor D:");
            double valorD = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double diferencaProduto = ((valorA * valorB) - (valorC * valorD));

            Console.WriteLine($"A diferença de produtos entre os valores corresponde à {diferencaProduto}");
        }
    }
}