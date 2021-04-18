using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    class Program
    {
        static double n1, n2;
        static void Main(string[] args)
        {
            SolicitarNumeros();
            Console.WriteLine("Informe a operação desejada: ");
            switch (Console.ReadLine().ToLower())
            {
                case "soma": Console.WriteLine("Soma: {0} + {1} = {2}", n1, n2, Somar(n1, n2)); break;
                case "subtração": Console.WriteLine("Subtração: {0} - {1} = {2}", n1, n2, Subtracao(n1, n2)); break;
                case "divisão": Console.WriteLine("Divisão: {0} / {1} = {2} ", n1, n2, Divisao(n1, n2)); break;
                case "multiplicação": Console.WriteLine("Multiplicação: {0} * {1} = {2}", n1, n2, Multiplicacao(n1, n2)); break;
                default: Console.WriteLine("Operação inválida"); break;
            }
            Console.ReadKey();
        }
        static void SolicitarNumeros()
        {
            Console.WriteLine("Número 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = double.Parse(Console.ReadLine());
        }
        static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        static double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        static double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
        static double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}
