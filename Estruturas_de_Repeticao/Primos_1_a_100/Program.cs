using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos_1_a_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i <= 100)
            {
                int j = 2;
                while (j < i && i % j != 0)
                
                    j++;
                    if (i == j)
                    
                        Console.WriteLine(i);
                        i++;
                    
                
            }
            Console.ReadKey();
        }
    }
}
