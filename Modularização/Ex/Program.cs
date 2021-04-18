using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Program
    {
        static double n1, n2;
        static void Main(string[] args)
        {
            SolicitarNumeros();
            double resultado = Somar(n1, n2);
            Console.WriteLine("O resultado foi: {0}", resultado);
            Console.ReadKey();
        }
        static void SolicitarNumeros()
        {
            Console.WriteLine("Número 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = double.Parse(Console.ReadLine());
        }
        static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
