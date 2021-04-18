using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

/*Descrição
1. Ao entrar no sistema, o usuário poderá escolher uma das opções oferecidas, que são:
a. Inserir um novo item;
b. Alterar os itens;
c. Consultar se um item existe;
d. Listar todos os itens inseridos.
e. Remover (Opcional)
2. Cada ITEM (pode ser um cadastro de estoque, de telefones, de alunos, de professores, de matérias, etc)
deve possuir no mínimo 3 informações cadastradas (ex.: No caso do estoque, devem ser cadastrados o Nome do Item e o seu Preço);
3. Devem ser utilizados conceitos de modularização;
4. Salvar os dados em arquivo, para que sejam abertos da próxima vez;
5. Utilizar o Winsows Form (Opcional)*/

namespace Trabalho
{
    class Program
    {
        public class DadosParaCadastro
        {
            public string nome;
            public double altura;
            public double peso;
        }
        static string endereco = @"C:\Users\cadastrouser.txt";
        static List<DadosParaCadastro> dadoParaCadastrado = new List<DadosParaCadastro>();
        static void Main(string[] args)
        {
            EscolherOPC();
            Console.WriteLine("....................................");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.WriteLine("....................................");
            Console.ReadKey();
        }
        static void EscolherOPC()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo! \n");
                Console.WriteLine("Selecione uma das opções abaixo: ");
                Console.WriteLine("....................................");
                Console.WriteLine("(1) Cadastrar");
                Console.WriteLine("(2) Alterar");
                Console.WriteLine("(3) Consultar");
                Console.WriteLine("(4) Listar");
                Console.WriteLine("(5) Remover");
                Console.WriteLine("(6) Abrir arquivo");
                Console.WriteLine("(7) Salvar");
                Console.WriteLine("....................................");

                int opc = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        DadosParaCadastro usuario = new DadosParaCadastro();
                        Cadastrar(usuario);
                        break;

                    case 2:
                        Alterar();
                        break;

                    case 3:
                        Console.WriteLine("Informe quem deseja encontrar: ");
                        bool encontrado = Consultar(Console.ReadLine());
                        break;

                    case 4:
                        Listar();
                        break;

                    case 5:
                        Remover();
                        break;

                    case 6:
                        AbrirArquivo();
                        break;

                    case 7:
                        SalvarArquivo();
                        break;

                }
                Console.WriteLine("Deseja continuar no programa? Digite: s p/ sim");
            } while (Console.ReadLine().ToLower() == "s");
        }
        static void Cadastrar(DadosParaCadastro usuario)
        {
            Console.WriteLine("Informe o nome:");
            usuario.nome = Console.ReadLine();
            Console.WriteLine("Informe a altura:");
            usuario.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o peso:");
            usuario.peso = double.Parse(Console.ReadLine());
            dadoParaCadastrado.Add(usuario);
            Console.WriteLine("Cadastro Realizado! \n");
        }
        static void Alterar()
        {
            if (dadoParaCadastrado.Count > 0)
            {
                Console.WriteLine("Digite o numero para edição: ");
                int contador = 1;
                foreach (DadosParaCadastro usuario in dadoParaCadastrado)
                {
                    Console.WriteLine("{0} - Nome: {1} | Altura: {2}m | Peso: {3}kg", contador, usuario.nome, usuario.altura, usuario.peso);
                    contador++;
                }
                int num = int.Parse(Console.ReadLine());
                if (num >= 0 && num < dadoParaCadastrado.Count)
                {
                    Console.WriteLine("Informe os dados para alteração");
                    Console.WriteLine("Informe o nome:");
                    dadoParaCadastrado[num ].nome = Console.ReadLine();
                    Console.WriteLine("Informe a altura:");
                    dadoParaCadastrado[num ].altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o peso:");
                    dadoParaCadastrado[num ].peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Alteração feita com sucesso! \n");
                }
            }
            else
            {
                Console.WriteLine("Não há pessoas cadastradas! \n");
            }
        }
        static bool Consultar(string nome)
        {
            bool encontrado = false;
            foreach (DadosParaCadastro usuario in dadoParaCadastrado)
            {
                if (usuario.nome.ToLower().Contains(nome.ToLower()))
                {
                    Console.WriteLine("Nome: {0} | Altura: {1}m | Peso: {2}kg", usuario.nome, usuario.altura, usuario.peso);
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Pessoa não encontrada! \n");
            }
            return encontrado;
        }
        static void Listar()
        {
            Console.WriteLine("Lista de todos os cadastrados: \n");
            foreach (DadosParaCadastro usuario in dadoParaCadastrado)
            {
                Console.WriteLine("Nome: {0} | Altura: {1}m | Peso: {2}kg", usuario.nome, usuario.altura, usuario.peso);
            }
        }
        static void Remover()
        {
            if (dadoParaCadastrado.Count > 0)
            {
                Console.WriteLine("Digite o número para Exclusão");
                int contador = 1;
                foreach (DadosParaCadastro usuario in dadoParaCadastrado)
                {
                    Console.WriteLine("{0} - Nome: {1} | Altura: {2}m | Peso: {3}kg", contador, usuario.nome, usuario.altura, usuario.peso);
                    contador++;
                }
                int num = int.Parse(Console.ReadLine());
                dadoParaCadastrado.Remove(dadoParaCadastrado[num - 1]);
                Console.WriteLine("Exclusão feita com sucesso! \n");
            }
            else
            {
                Console.WriteLine("Não há pessoas cadastradas! \n");
            }
        }
        static void AbrirArquivo()
        {
            if (File.Exists(endereco))
            {
                string[] linhas = File.ReadAllLines(endereco);
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split('-');
                    DadosParaCadastro usersalvo = new DadosParaCadastro();
                    usersalvo.nome = partes[0];
                    usersalvo.altura = double.Parse(partes[1]);
                    usersalvo.peso = double.Parse(partes[2]);
                    dadoParaCadastrado.Add(usersalvo);
                }
            }
            else
            {
                Console.WriteLine("Nenhum arquivo foi criado... \n");
            }
        }
        static void SalvarArquivo()
        {
            StreamWriter file = new StreamWriter(endereco);
            foreach (DadosParaCadastro usuario in dadoParaCadastrado)
            {
                file.WriteLine("{0}-{1}-{2}", usuario.nome, usuario.altura, usuario.peso);
            }
            Console.WriteLine("Arquivo salvo com sucesso! \n");
            file.Close();
        }
    }
}