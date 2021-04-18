using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09_SOMAPARES_IMPARES
{
    class Program
    {
        static void Main(string[] args)
        {
            int somapares = 0, somaimpares = 0, numero;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Informe o número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    somapares += numero;
                }
                else
                {
                    somaimpares += numero;
                }
            }
            Console.WriteLine("A soma dos pares é: {0}, e dos impares é: {1}", somapares, somaimpares);
            Console.ReadKey();
        }
    }
}
