using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Questão_1
{
    class Program
    {
        static string operador;
        static int n1, n2;
        static void Main(string[] args)
        {
            ReceberNumeros();
            double resultado = Somar(n1, n2);
            Console.WriteLine("Escreva qual vai ser a operação:");
            operador = Console.ReadLine();
            operador = operador.ToLower();
            Console.WriteLine("O resultado da soma é {0}", resultado);
            double resposta = Subtrair(n1, n2);
            Console.WriteLine("O resultado da subtração é {0}", resposta);
            double respost = Multiplicar(n1, n2);
            Console.WriteLine("O resultado da multiplicação é {0}", respost);
            double result = Dividir(n1, n2);
            Console.WriteLine("O resultado da divisão é {0}", result);
            Console.ReadKey();
        }
        static void ReceberNumeros()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Escreva números aleatórios");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
            }
        }
        static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}