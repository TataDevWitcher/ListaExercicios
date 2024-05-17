using System;
using System.Globalization;

namespace ExercicioValorProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Cálculo valores dos produtos*");
            Console.WriteLine("Obs.: Use a vírgula como separador de casas decimais");

            Produto produto = new Produto();

            Console.WriteLine("Insira o nome do produto, o preço e a quantidade respectivamente separados por um espaço:");
            string[] dadosProduto = Console.ReadLine().Split(' ');
            produto.Nome = dadosProduto[0];
            produto.Preco = double.Parse(dadosProduto[1]);
            produto.Quantidade = int.Parse(dadosProduto[2]);

            Console.WriteLine("Dados do produto: " + produto);
            //Consigo agora chamar a variável sem problemas por causa da implementação do método override na classe Produto

            Console.WriteLine("");
            Console.WriteLine("Entrada no estoque, informe a quantidade adicionada:");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine("");
            Console.WriteLine("Saída no estoque, informe a quantidade removida:");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}