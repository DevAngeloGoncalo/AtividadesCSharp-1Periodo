using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    class Program
    {
        static double n1, n2;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Número 1:");
            } while (!double.TryParse(Console.ReadLine(), out n1));
            do
            {
                Console.WriteLine("Número 2:");
            } while (!double.TryParse(Console.ReadLine(), out n2));
            Console.WriteLine("Qual é a operação?");
            switch (Console.ReadLine())
            {
                case "Somar":
                    Console.WriteLine("A soma foi: {0}", Somar(n1, n2));
                    break;
                default:
                    Console.WriteLine("Operação inválida !");
                    break;
            }
            Console.ReadKey();
        }

        static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
