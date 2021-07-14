using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o comando Switch");
            Console.WriteLine("");

            Console.WriteLine("Digite o mês correspondente: ");
            int mes = Int32.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês é janeiro!");
                    break;
                case 2:
                    Console.WriteLine("O mês é fevereiro!");
                    break;
                case 3:
                    Console.WriteLine("O mês é março!");
                    break;
                case 4:
                    Console.WriteLine("O mês é abril!");
                    break;
                case 5:
                    Console.WriteLine("O mês é maio!");
                    break;
                case 6:
                    Console.WriteLine("O mês é junho!");
                    break;
                case 7:
                    Console.WriteLine("O mês é julho!");
                    break;
                case 8:
                    Console.WriteLine("O mês é agosto!");
                    break;
                case 9:
                    Console.WriteLine("O mês é setembro!");
                    break;
                case 10:
                    Console.WriteLine("O mês é outubro!");
                    break;
                case 11:
                    Console.WriteLine("O mês é novembro!");
                    break;
                case 12:
                    Console.WriteLine("O mês é dezembro!");
                    break;

                default:
                    Console.WriteLine("O mês é inválido");
                    break;
            }




            Console.ReadLine();
        }
    }
}
