using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_Parcelada
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDasPrestacoesSemJuros, valorDeUmaCompra;
            int quantidadeDePrestacoes;
            Console.WriteLine("informe o valor da Compra em R$:");
            valorDeUmaCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de Prestações: ");
            quantidadeDePrestacoes = int.Parse(Console.ReadLine());
            valorDasPrestacoesSemJuros = (valorDeUmaCompra / quantidadeDePrestacoes);
            Console.WriteLine("Serão efetuados {0} prestações no valor de: R${1}", quantidadeDePrestacoes, valorDasPrestacoesSemJuros);
            Console.ReadKey();
        }
    }
}
