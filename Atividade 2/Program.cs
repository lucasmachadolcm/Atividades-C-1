
string nome;
string sexo;
string estado;
int tempo;

Console.WriteLine("Digite o Nome");
nome = Console.ReadLine();
Console.WriteLine("Digite o sexo");
sexo = Console.ReadLine();
Console.WriteLine("Digite o estado civil");
estado = Console.ReadLine();
if ((sexo == "F") && (estado == "casada"))
{
    Console.WriteLine("Digite o tempo de casamento");
    tempo = int.Parse(Console.ReadLine());
}
Console.ReadLine(); 