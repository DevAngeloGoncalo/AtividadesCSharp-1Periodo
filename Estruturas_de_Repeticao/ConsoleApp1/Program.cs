using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
                if (i % 7 == 0)
            { 
                {
                Console.WriteLine(i);
                i++;
                }
            } while (i <= 100);
            Console.ReadKey();
        }
    }
}
