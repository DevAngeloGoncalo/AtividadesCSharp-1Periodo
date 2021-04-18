using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprego_Comissao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, novoSalario;

            Console.WriteLine("Qual o nome do Vendedor?");
            Console.WriteLine("Informe seu salário: ");
            Console.WriteLine("Informe as vendas realizadas pelo vendedor (EM DINHEIRO): ");
            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());
            novoSalario = salario + (vendas * 15 / 100);
            Console.WriteLine("O nome do vendedor é: {0}", nome);
            Console.WriteLine("Que tem um salário de: {0}", salario);
            Console.WriteLine("O vendedor conseguiu vender um total de: R$ {0} ", vendas);
            Console.WriteLine("Possuindo assim um salario total de: R$ {0}", novoSalario);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
