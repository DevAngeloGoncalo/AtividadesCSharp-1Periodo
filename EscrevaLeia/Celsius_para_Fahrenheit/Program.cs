using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_para_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, fahrenheit;
            Console.WriteLine("Informe a temperatura em Celsius");
            celsius = int.Parse(Console.ReadLine());
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("A temperatura em fahrenheit é de: {0} °", fahrenheit);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
    }
}
