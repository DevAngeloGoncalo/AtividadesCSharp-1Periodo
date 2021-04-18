using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel_Km_Litros
{
    class Program
    {
        static void Main(string[] args)
        {
            int consumoMedio, distanciaTotal, combustivelGasto;
            Console.WriteLine("Informe a distância percorrida");
            Console.WriteLine("Informe a qualtidade de combustível gasto");
            distanciaTotal = int.Parse(Console.ReadLine());
            combustivelGasto = int.Parse(Console.ReadLine());
            consumoMedio = distanciaTotal / combustivelGasto;
            Console.WriteLine("O consumo médio do automóvel é de: {0} Km/L", consumoMedio);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
