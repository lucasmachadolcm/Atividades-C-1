int A = 0;
int B = 0;
int soma = 0;
int C = 0;

Console.WriteLine("Digite o valor de A");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B");
B = int.Parse(Console.ReadLine());  

if (A == B)
{
    soma = A + B;
}
else
{
    soma = A * B;
}

C = soma;

Console.WriteLine("O resultado do cálculo é: " + soma);
Console.ReadLine();