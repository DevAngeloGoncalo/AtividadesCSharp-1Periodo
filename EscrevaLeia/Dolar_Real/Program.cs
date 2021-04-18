using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, real, cotacao;
            Console.WriteLine("Informe a quantidade do valor em R$");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a cotação do dólar");
            cotacao = double.Parse(Console.ReadLine());
            dolar = real / cotacao;
            Console.WriteLine("Você possui US$ {0}", dolar);
            Console.WriteLine(" A cotação do dólar está no valor de R$ {0}", cotacao);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
