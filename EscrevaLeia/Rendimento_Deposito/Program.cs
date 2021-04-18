using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento_Deposito
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDepositado, rendimentoAposUmMes;
            Console.WriteLine("Informe o valor depositado em R$");
            valorDepositado = double.Parse(Console.ReadLine());
            rendimentoAposUmMes = (valorDepositado + (valorDepositado * (0.7 / 100)));
            Console.WriteLine("O seu rendimento é de R$ {0}", rendimentoAposUmMes);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
