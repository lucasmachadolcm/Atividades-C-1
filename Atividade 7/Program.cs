﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;

            int calc = 0;

            Console.WriteLine("Digite o valor a ser verificado");
            n1 = int.Parse(Console.ReadLine());
            calc = n1 % 2;

            if (calc == 0)
            {
                n1 = n1 + 5;
                Console.WriteLine("O número é par e o resultado da conta é: "+n1);
            }
            else
            {
                n1 = n1 + 8;
                Console.WriteLine("O número é impar e o resultado da conta é: " + n1);
            }
            Console.ReadLine();

        }
    }
}
