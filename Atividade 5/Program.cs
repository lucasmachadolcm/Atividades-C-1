int num = 0;
int calc = 0;

Console.WriteLine("Digite um número inteiro");
num = int.Parse(Console.ReadLine());

if (num > 0)
{
    calc = num * 2;
    Console.WriteLine("O número digitado é positivo, o seu dobro é: " + calc);
}

else
{
    calc = num * 3;
    Console.WriteLine("O número digitado é negativo, o seu triplo é: " + calc);
}

Console.ReadLine();