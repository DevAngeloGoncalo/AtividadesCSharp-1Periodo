using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06_CIGARRO
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, soma = 0, anos, numcig;
            Console.WriteLine("Informe o número de cigarros fumados por dia");
            numcig = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantos anos você fuma");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da caixa de cigarro: ");
            preco = int.Parse(Console.ReadLine());
            if (preco > 0)
            {
                soma = ((anos * 365) * (numcig / 20)) * preco;
                Console.WriteLine("O valor gasto em cigarros é de R${0}", soma);
            }
            else
            {
                Console.WriteLine("Preço inválido");
            }
            Console.ReadKey();
        }
    }
}
