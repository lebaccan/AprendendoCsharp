﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Um_erro_compilacao
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.ReadLine();
        }
    }
}
