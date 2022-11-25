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
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            double oat = 0;
            double ma = 0;
            int cod = 0;
            Console.WriteLine("Digite o código do aluno");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota das atividades");
            oat = double.Parse(Console.ReadLine());

            ma = (n1 + (n2*2) + (n3*3) + oat ) / 7;
            
            if (ma >= 90)
            {
                Console.WriteLine("Aluno aprovado com conceito A. Sua média final é: " + ma);
            }
            else if (ma >= 75 && ma < 90)
            {
                Console.WriteLine("Aluno aprovado com conceito B. Sua média final é: " + ma);
            }
            else if (ma >= 60 && ma < 75)
            {
                Console.WriteLine("Aluno aprovado com conceito C. Sua média final é: " + ma);
            }
            else if (ma >= 40 && ma < 60)
            {
                Console.WriteLine("Aluno reprovado com conceito D. Sua média final é: " + ma);
            }
            else
            {
                Console.WriteLine("Aluno reprovado com conceito E. Sua média final é: " + ma);
            }

            Console.ReadLine();
        }
    }
}
