using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03_Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, mult;
            Console.WriteLine("Informe número 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe número 2");
            num2 = double.Parse(Console.ReadLine());
            mult = num1 * num2;
            Console.WriteLine("O resultado é: {0}", mult);
            Console.ReadKey();
        }
    }
}
5