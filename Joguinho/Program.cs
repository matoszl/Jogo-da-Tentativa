Random aleatorio = new Random();
int numeroescolhido = aleatorio.Next(1, 101);

Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░░█████╗░
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔══██╗
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║███████║
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██╔══██║
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝██║░░██║
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░╚═╝░░╚═╝

████████╗███████╗███╗░░██╗████████╗░█████╗░████████╗██╗██╗░░░██╗░█████╗░
╚══██╔══╝██╔════╝████╗░██║╚══██╔══╝██╔══██╗╚══██╔══╝██║██║░░░██║██╔══██╗
░░░██║░░░█████╗░░██╔██╗██║░░░██║░░░███████║░░░██║░░░██║╚██╗░██╔╝███████║
░░░██║░░░██╔══╝░░██║╚████║░░░██║░░░██╔══██║░░░██║░░░██║░╚████╔╝░██╔══██║
░░░██║░░░███████╗██║░╚███║░░░██║░░░██║░░██║░░░██║░░░██║░░╚██╔╝░░██║░░██║
░░░╚═╝░░░╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝");
Console.WriteLine("\nSeja bem-vindo(a)!");
Console.WriteLine("\nVocê possui até 7 chances para acertar o número escolhido. O número escolhido está entre 1 e 100. A cada tentativa o jogo te informará se o número escolhido é maior ou menor que o digitado. \n");

int chances = 1;
bool acertou = false;
do
{
    Console.Write("Digite um número: ");
    int tentativa = int.Parse(Console.ReadLine()!);
    if (tentativa > 0 && tentativa <= 100)
    {
        if (tentativa > numeroescolhido)
        {
            Console.WriteLine("O número é menor");
        }
        else if (tentativa < numeroescolhido)
        {
            Console.WriteLine("O número é maior!");
        }
        else if (tentativa == numeroescolhido)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nVocê acertou o número escolhido !!! Parabéns !!! Fim de jogo !!!");
            Console.ResetColor();
            break;
        }
        chances++;
    }else
    {
        Console.WriteLine("O número deve estar entre 1 e 100");
    }

    if (chances == 8)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nQue pena... você perdeu!!! O limite de chances foi atingido!!!");
        Console.ResetColor();
        Console.WriteLine($"\nO número escolhido era: {numeroescolhido}");
    }
} while (chances <= 7);

Console.WriteLine("\nPressione qualquer tecla para continuar...");
Console.ReadLine();



