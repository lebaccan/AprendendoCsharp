using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o Projeto 4 - Conversões outros tipos numéricos.");

            double salario = 1200.50;
            Console.WriteLine("Meu salário é: " + salario);

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("O salário inteiro é: " + salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idadeUniverso = 13000000000;
            Console.WriteLine("A idade do universo é: " + idadeUniverso);

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine("A quantidade de produtos são: " + quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine("Minha altura é: " + altura);







            Console.ReadLine();
        }
    }
}
