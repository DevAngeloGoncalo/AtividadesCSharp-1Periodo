using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordem_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, aux;
            Console.WriteLine("Informe o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            else if (n1 > n3)
            {
                aux = n1;
                n1 = n3;
                n3 = aux;
            }
            else if (n2 > n3)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            Console.WriteLine("{0}, {1}, {2}", n1, n2, n3);
            Console.ReadKey();
        }
    }
}
