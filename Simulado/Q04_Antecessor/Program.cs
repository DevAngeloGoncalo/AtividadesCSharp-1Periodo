using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Antecessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ant;
            Console.WriteLine("Informe o número desejado");
            num = int.Parse(Console.ReadLine());
            ant = num - 1;
            Console.WriteLine("O antecessor é: {0}", ant);
            Console.ReadKey();
        }
    }
}
