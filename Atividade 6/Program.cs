﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(n1 == n2);
            }
            else
            { 
                Console.WriteLine(n1 == n2);
            }
            Console.ReadLine(); 
        }
    }
}
