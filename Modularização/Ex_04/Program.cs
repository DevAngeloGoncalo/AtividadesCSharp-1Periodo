using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = Somar(numero1, numero2);
            Console.Write("Resultado: {0}",resultado);
            Console.ReadKey();
        }
        public static int Somar(int numero1,
        int numero2)
        {
            return numero1 + numero2;
        }
    }
}
