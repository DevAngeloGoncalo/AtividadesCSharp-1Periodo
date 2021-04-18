using System;
using System.Collections;

namespace ArraylistModularizado
{
    class Program
    {
        static ArrayList listaJogos = new ArrayList();

        static void Main(string[] args)
        {
            Inserir();
            Inserir();
            Inserir();
            Inserir();
            Listar();
            Console.WriteLine("Qual jogo deseja buscar?");
            bool encontrado = Procurar(Console.ReadLine());
            if (encontrado == false)
            {
                Console.WriteLine("Não encontrado !");
            }
            Console.ReadKey();
        }

        static void Inserir()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Informe o jogo: ");
            listaJogos.Add(Console.ReadLine());
            Console.Clear();
        }

        static void Listar()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Listando ...");
            foreach (string jogo in listaJogos)
            {
                Console.WriteLine("Jogo: {0}", jogo);
            }
        }

        static bool Procurar(string jogoProcurado)
        {
            bool encontrado = false;
            foreach (string jogo in listaJogos)
            {
                if (jogo.ToLower().Contains(jogoProcurado.ToLower()))
                {
                    Console.WriteLine("Encontrado: {0}", jogo);
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }
}