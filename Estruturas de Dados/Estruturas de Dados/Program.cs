using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe o nome: ");
                nomes[i] = Console.ReadLine();
            }
            for (int i = 0; i < nomes.Length; i++)

            {
                Console.WriteLine("O nome inserido foi: {0} ", nomes[i]);
            }
            Console.ReadKey();
        }
    }
}
