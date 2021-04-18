using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04b
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho;
            Console.WriteLine("Qual deve ser o número de repetições ?");
            tamanho = int.Parse(Console.ReadLine());
            int[] valor = new int[tamanho];
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("Informe um número: ");
                valor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("O valor da posição {0} é {1}", i, valor[i]);
            }
            Console.ReadKey();
        }
    }
}
