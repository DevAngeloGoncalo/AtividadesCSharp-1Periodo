using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.WriteLine("Informe o primeiro número");
            Console.WriteLine("Informe o Segundo número");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("O resultado da Soma é: {0}", soma);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
