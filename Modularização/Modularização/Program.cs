using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Somar();
            Console.ReadKey();
        }
        public static void Somar()
        {
            Console.WriteLine("Digite o primeiro número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado {0}", numero1 + numero2);
        }
    }
}
