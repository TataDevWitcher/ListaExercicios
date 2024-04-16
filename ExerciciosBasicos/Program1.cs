using System;

namespace Exercicio1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Soma de dois valores*");

            Console.WriteLine("Entre com o primeiro número inteiro:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número inteiro:");
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}