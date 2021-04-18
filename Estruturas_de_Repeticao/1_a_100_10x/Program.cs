using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_a_100_10x
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i += 10;
            } while (i <= 100);
            Console.ReadKey();
        } 
    }
}
