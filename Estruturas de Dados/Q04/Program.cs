using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04a
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
                valor[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}

