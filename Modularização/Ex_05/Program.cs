using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    class Program
    {
        public static int n1, n2;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número 2: ");
            n2 = int.Parse(Console.ReadLine());
            int resultado = Somar(n1, n2);
            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
        }
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
