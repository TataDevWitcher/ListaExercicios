﻿using System;
using System.Globalization;

namespace Exercicios4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Salário de um funcionário*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            int numeroFuncionario;
            double horasTrabalhadas, recebeHora, salario;

            Console.WriteLine("Digite o número do funcionário:");
            numeroFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor recebido por hora desse funcionário:");
            recebeHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * recebeHora;

            Console.WriteLine($"O salário do funcionário equivale à R$: {salario:F2}");
        }
    }
    
}