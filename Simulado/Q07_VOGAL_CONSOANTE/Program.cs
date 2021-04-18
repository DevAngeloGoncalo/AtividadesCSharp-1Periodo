using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07_VOGAL_CONSOANTE
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Informe uma letra:");

            letra = char.Parse(Console.ReadLine().ToLower());

            switch (letra)
            {

                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0} é vogal.", letra);
                    break;

                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    Console.WriteLine("{0} é consoante.", letra);
                    break;

                default:
                    Console.WriteLine("{0} não é nem vogal e nem consoante.", letra);
                    break;
            }
            Console.ReadKey();
        }
    }
}
