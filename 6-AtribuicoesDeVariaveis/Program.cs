using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executanto 6 - AtribuicoesDeVariaveis");

            int idade = 44;
            int idadeLeandro = idade;

            idade = 45;

            Console.WriteLine(idade);
            Console.WriteLine(idadeLeandro);



            Console.WriteLine("Press enter. . . ");
            Console.ReadLine();
        }
    }
}
