using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_Pessoaprocura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3];
            double[] alt = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("A pessoa é: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Sua altura é: ");
                alt[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Procurar por: ");
            string pp = Console.ReadLine();

            Console.ReadKey();
        }
    }
}