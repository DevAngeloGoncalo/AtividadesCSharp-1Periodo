using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_entre_eles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f;
            Console.WriteLine("Informe o valor inicial: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor final: ");
            f = int.Parse(Console.ReadLine());
            for (; i <= f; i++)
            {
                Console.WriteLine("o número é: {0}", i);
            }
            Console.ReadKey();
        }
    }
}