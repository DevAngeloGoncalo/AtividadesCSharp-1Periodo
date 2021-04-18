using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 3;
            string[] nomes = new string[tamanho];
            double[] alturas = new double[tamanho];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe um nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Informe uma altura: ");
                alturas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Procurar:");
            string pessoaProcurar = Console.ReadLine();
            bool encontrado = false;
            for (int j = 0; j < nomes.Length; j++)
            {
                if (nomes[j] == pessoaProcurar)
                {
                    encontrado = true;
                    Console.Write("---->");
                }
                Console.Write("Nome: {0} - Altura: {1} \n", nomes[j], alturas[j]);
            }
            if (!encontrado)
            {
                Console.WriteLine("Não encontrado !");
            }
            Console.ReadKey();
        }

    }
}



