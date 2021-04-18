using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_Pares_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int somadospares = 0, somadosimpares = 0, num;
            for (int i = 0;  i < 4; i++ )
            {
                Console.WriteLine("Digite os números: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    somadospares += num;
                }
                else
                {
                    somadosimpares += num;
                }
            }
            Console.WriteLine("A soma dos números pares são: {0}, e a dos números impares: {1}", somadospares, somadosimpares);
            Console.ReadKey();
        }
    }
}
