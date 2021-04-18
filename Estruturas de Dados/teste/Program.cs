using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];       //um array de string de tamanho máximo 10
            double[] altura = new double[10];       //um array de double de tamanho máximo 10
            int tamanhoArray;
            string pessoaProcurada;

            Console.WriteLine("insira o tamanho do array");
            tamanhoArray = int.Parse(Console.ReadLine()); //pegamos o valor do tamanho do array 

            if ((tamanhoArray > 0) && (tamanhoArray <= 10))    //testamos se o valor é válido
            {
                //PEGANDO OS VALORES
                for (int i = 0; i < tamanhoArray; i++)    //começa do 0 até  o número anterior ao tamanhho digitado pelo usuário
                {
                    Console.WriteLine("Digite o nome:");
                    nome[i] = Console.ReadLine();  //recebe uma string do usuário e coloca na posição ' i '
                    Console.WriteLine("Digite a altura:");
                    altura[i] = double.Parse(Console.ReadLine());  //recebe um double e coloca na posição ' i '
                }

                Console.Clear();

                Console.WriteLine("Digite o nome da pessoa procurada:");
                pessoaProcurada = Console.ReadLine(); //recebe o nome da pessoa procurada e coloca na variável

                for (int i = 0; i < tamanhoArray; i++)
                {
                    if (pessoaProcurada.ToLower() == nome[i].ToLower())
                    {   //se a pessoa existir vai exibir o nome dela junto com a altura dela
                        Console.WriteLine("Nome: {0} -> Altura: {1}", nome[i], string.Format("{0:N}", altura[i]));
                    }
                    else
                    {
                        Console.WriteLine("Nome: {0}", nome[i]);  //imprime os demais nomes sem a altura
                    }
                }

            }
            else
            {
                Console.WriteLine("Tamanho inválido!"); //mensagem de erro!
            }
            Console.ReadKey();
        }
    }
}
