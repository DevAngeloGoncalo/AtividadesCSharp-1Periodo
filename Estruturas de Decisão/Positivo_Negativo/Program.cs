using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivo_Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("informe o primeiro número:");
            num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            if (num < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
