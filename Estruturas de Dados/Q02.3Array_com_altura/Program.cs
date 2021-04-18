using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02._3Array_com_altura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];
            double[] altura = new double[3];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe o nome e a Altura");
                nomes[i] = Console.ReadLine();
                altura[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("O usuário {0} tem {1}m de altura.", nomes[i], altura[i]);
            }
            Console.ReadKey();
        }
    }
}
