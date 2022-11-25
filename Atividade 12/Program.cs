using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 0;
            int op = 0;
            decimal calc1 = 0;
            decimal valorf = 0;
            Console.WriteLine("Digite o valor do produto");
            valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a forma de pagamento");
            Console.WriteLine("Digite 1 para pagamento a vista em chegue ou dinheiro");
            Console.WriteLine("Digite 2 para pagamento a vista no cartão de crédito");
            Console.WriteLine("Digite 3 para pagamento em duas vezes");
            Console.WriteLine("Digite 4 para pagamento em mais de duas vezes");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    calc1 = valor * (10 / 100);
                    valorf = valor - calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;

                case 2:
                    calc1 = valor * (15 / 100);
                    valorf = valor - calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;

                case 3:
                    Console.WriteLine("O valor total da compra dividido em duas vezes é: " + valor);
                    break;

                case 4:
                    calc1 = valor * (10 / 100);
                    valorf = valor + calc1;
                    Console.WriteLine("O valor total da compra é: " + valorf);
                    break;
            }
            Console.ReadLine();
        }
    }
}
