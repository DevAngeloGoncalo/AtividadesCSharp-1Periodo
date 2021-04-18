using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_e_Venda
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDoProduto, valorDaVenda, valorDeAcrescimo, valorEmPorcentagem;
            Console.WriteLine("informe o Preço do produto em R$:");
            valorDoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe por quanto você deseja vender o produto em R$: ");
            valorDaVenda = double.Parse(Console.ReadLine());
            valorDeAcrescimo = (valorDaVenda - valorDoProduto);
            valorEmPorcentagem = ((valorDaVenda - valorDoProduto) / valorDoProduto) * 100;
            Console.WriteLine("O lucro é de R${0} com acrescimo de {1}%", valorDeAcrescimo, valorEmPorcentagem);
            Console.ReadKey();
        }
    }
}
