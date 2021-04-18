using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Válida
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Informe o dia, mês e ano (dd/ mm/ aaaa): ");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            ano = int.Parse(Console.ReadLine());
            if (ano > 0)
            {
                if (((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12)) && ((dia <= 31) && (dia > 0)))
                {
                    Console.WriteLine("Data inserida corretamente: {0}/ {1}/ {2}", dia, mes, ano);
                }
                else if (((mes == 4) || (mes == 6) || (mes == 9)) || ((mes == 11) && (dia <= 30) && (dia > 0)))
                {
                    Console.WriteLine("Data inserida corretamente: {0}/ {1}/ {2}", dia, mes, ano);
                }
                else if (((mes == 2) && (ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 == 0)) && ((dia > 0) && (dia <= 29)))
                {
                    Console.WriteLine("Ano Bissexto");
                    Console.WriteLine("Data inserida corretamente: {0}/ {1}/ {2}", dia, mes, ano);
                }
                else if (((mes == 2) && (ano % 4 != 0) && (ano % 100 == 0) || (ano % 400 != 0)) && ((dia > 0) && (dia <= 28)))
                {
                    Console.WriteLine("Data inserida corretamente: {0}/ {1}/ {2}", dia, mes, ano);
                }
                else
                {
                    Console.WriteLine("Data Inválida"); //calendario
                }
            }
            Console.ReadKey();


            
        }
    }
}

