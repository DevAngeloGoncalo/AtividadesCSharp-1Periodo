using System;
using System.Collections;

namespace Ex_09
{
    class Program
    {
        static ArrayList lista = new ArrayList();
        static void Main(string[] args)
        {
            InserirListando();
            InserirListando();
            InserirListando();
            InserirListando();
            Console.WriteLine("Procurar:");
            bool encontrado = Procurar(Console.ReadLine());
            if (!encontrado)
            {
                Console.WriteLine("Valor não existe");
            }
            Console.ReadKey();
        }

        static void InserirListando()
        {
            Inserir();
            Listar();
            Console.ReadKey();
            Console.Clear();
        }
        static void Inserir()
        {
            //Colocar todo o código para inserir ...
            Console.WriteLine("Informe um nome:");
            lista.Add(Console.ReadLine());
            Console.Clear();
        }
        static void Listar()
        {
            //Colocar todo o código para listar...
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        static bool Procurar(string nome)
        {
            bool encontrado = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] as string == nome)
                {
                    Console.WriteLine("Encontrado: {0}", lista[i]);
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }
}
