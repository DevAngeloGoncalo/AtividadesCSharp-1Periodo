using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("informe o número:");
            num = double.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("O número é divisivel por 5");
            }
            else
            {
                Console.WriteLine("O número não é divisível por 5");
            }
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
