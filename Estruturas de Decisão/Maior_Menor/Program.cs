using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Menor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("informe o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o segundo número:");
            num2 = double.Parse(Console.ReadLine()); 
            if (num1 > num2)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("O segundo número é maior");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais");
            }
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();       
        }
    }
}
