using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            OlaPessoa(Console.ReadLine());
        }

        public static void OlaPessoa(String nome)
        {
            Console.WriteLine("Olá {0}", nome);
            Console.ReadKey();
        }
    }
}
