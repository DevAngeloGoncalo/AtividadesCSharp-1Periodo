using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma, mult, divi, subt;
            Console.WriteLine("Informe o primeiro número");
            Console.WriteLine("Informe o segundo número");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            soma = num1 + num2;
            mult = num1 * num2;
            divi = num1 / num2;
            subt = num1 - num2;
            Console.WriteLine("O resultado da Soma é: {0}", soma);
            Console.WriteLine("O resultado da multiplicação é: {0}", mult);
            Console.WriteLine("O resultado da divisão é: {0}", divi);
            Console.WriteLine("O resultado da subtração é: {0}", subt);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
