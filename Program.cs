Console.WriteLine("Tabuadas");
int numero = 0;
int tabuada = 0;
string resposta;

do
{
    Console.WriteLine("Qual a tabuada você deseja?");
    tabuada = int.Parse(Console.ReadLine());

    while (numero <= 10)
    {
        Console.WriteLine($"{tabuada} x {numero} = {numero * tabuada}");
        numero++;
    }
    numero = 0;

    Console.WriteLine("Deseja gerar outra tabuada?");
    resposta = Console.ReadLine();
    Console.Clear();
} while (resposta == "s");