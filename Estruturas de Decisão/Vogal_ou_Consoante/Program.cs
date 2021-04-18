using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogal_ou_Consoante
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Informe a letra: ");
            letra = char.Parse(Console.ReadLine().ToLower());
            if
                ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u')) 
            { 
            Console.WriteLine("A letra {0} é uma vogal", letra);
            }
            else
            { 
                Console.WriteLine("A letra {0} é uma consoante", letra);
            }
            Console.ReadKey();
        }
    }
}
