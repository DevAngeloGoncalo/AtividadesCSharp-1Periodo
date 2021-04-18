using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_Aprovado_Reprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            if (media == 10)
            {
                Console.WriteLine("Média = {0}, Aprovado com dinstinção!", media);
            }
            else if ((media <= 10) && (media >= 7))
            {
                Console.WriteLine("Média = {0}, Aprovado", media);
            }
            else
            {
                Console.WriteLine("Média = {0}, Reprovado KKKKKKKKKKKK", media);
            }
            Console.ReadKey();
        }
    }
}
