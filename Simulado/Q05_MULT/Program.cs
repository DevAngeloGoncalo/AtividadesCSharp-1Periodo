using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_MULT
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Informe o primeiro valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                Console.WriteLine("O número {0} é multiplo de {1}", x, y);
            }
            else
            {
                Console.WriteLine("O número {0} não é multiplo de {1}", x, y);
            }
            Console.ReadKey();
        }
    }
}
