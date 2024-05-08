using System;
using System.Globalization;

namespace Exercicio5
{
    class Program5
    {
        static void Main (string[] args)
        {
            Console.WriteLine("*Peças - Valor total*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            int codigoPeca1, quantidadePecas1, codigoPrca2, quantidadePecas2;
            double valorUnitarioPeca1, valorUnitarioPeca2, total;

            Console.WriteLine("Primeira Peça - Insira o código, a quantidade e o valor unitário respectivamente separados por um espaço:");
            string[] informacoesPeca = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(informacoesPeca[0]);
            quantidadePecas1 = int.Parse(informacoesPeca[1]);
            valorUnitarioPeca1 = double.Parse(informacoesPeca[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Segunda Peça - Insira o código, a quantidade e o valor unitário respectivamente separados por um espaço:");
            informacoesPeca = Console.ReadLine().Split(' ');
            codigoPrca2 = int.Parse(informacoesPeca[0]);
            quantidadePecas2 = int.Parse(informacoesPeca[1]);
            valorUnitarioPeca2 = double.Parse(informacoesPeca[2], CultureInfo.InvariantCulture);

            total = (quantidadePecas1 * valorUnitarioPeca1) + (quantidadePecas2 * valorUnitarioPeca2);

            Console.WriteLine($"Total a pagar: R${total:F2}");
            //ou Console.WriteLine("Total a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}