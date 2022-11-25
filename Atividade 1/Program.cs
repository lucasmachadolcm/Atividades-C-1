// See https://aka.ms/new-console-template for more information

decimal v1 = 0;
decimal v2 = 0;
decimal v3 = 0;
decimal soma = 0;
Console.WriteLine("Soma de valores");
Console.WriteLine("Digite o valor de A");
v1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B");
v2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C");
v3 = decimal.Parse(Console.ReadLine());
soma = v1 + v2 ;
if (soma > v3)
{
    Console.WriteLine("A soma de A + B é maior que C");
}
    else
    {
        Console.WriteLine("O valor de C é maior que a soma de A + B");
    }
Console.ReadLine();
