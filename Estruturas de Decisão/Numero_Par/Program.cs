using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("informe o número:");
            num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            Console.WriteLine("Número é Impar");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
