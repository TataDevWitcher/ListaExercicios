using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioValorProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public double AdicionarProdutos(int quantidade)
        {
            return Quantidade += quantidade;
        }

        public double RemoverProdutos(int quantidade)
        {
            return Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade.ToString("F2", CultureInfo.InvariantCulture)
                + " unidades, Total:"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
