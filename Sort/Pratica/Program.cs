using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList carros = new ArrayList();
            carros.Add("Camaro");
            carros.Add("Corolla");
            carros.Add("Audi A3");
            carros.Add("Uno");
            carros.Add("Celta");
            carros.Add("Gol");
   
            var ListaCarros = new List<String>();
            ListaCarros.AddRange(carros);
            Console.WriteLine("List in unsorted order: ");
            foreach (string carro in ListaCarros)
                Console.Write("   {0}", carro);

            Console.WriteLine(Environment.NewLine);

            nameList.Sort();
            Console.WriteLine("List in sorted order: ");
            foreach (var name in nameList)
                Console.Write("   {0}", name);

            Console.WriteLine();
        }
    }
}
