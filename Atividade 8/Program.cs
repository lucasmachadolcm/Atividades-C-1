using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.Write("\n\n");
            foreach (int i in numeros) Console.WriteLine(i);
            Console.ReadLine();
        }

    }
}

