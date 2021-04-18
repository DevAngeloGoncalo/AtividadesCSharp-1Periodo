using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01
{
    class Program
    {
        static double n1, n2;
        static void Main(string[] args)
        {
            SolicitarNumeros();
            double resultadoS = Somar(n1, n2);
            Console.WriteLine("{0} + {1} = {2}",n1, n2, resultadoS);
            double resultadoSub = Subtracao(n1, n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, resultadoSub);
            double resultadoD = Divisao(n1, n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, resultadoD);
            double resultadoM = Multiplicacao(n1, n2);
            Console.WriteLine("{0} * {1} = {2}", n1, n2, resultadoM);
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
