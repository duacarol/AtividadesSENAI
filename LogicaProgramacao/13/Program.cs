Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(new string('=', 31));
Console.WriteLine("Sorteio de Dezenas :: Mega-Sena");
Console.WriteLine(new string('=', 31));
Console.ResetColor();

int qntJogos, qntDezenas;

while (true)
{
    Console.Write("Informe a quantidade de jogos: ");
    if (int.TryParse(Console.ReadLine(), out qntJogos) && qntJogos > 0)
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, insira um número maior que 0.");
        Console.ResetColor();
    }
}

while (true)
{
    Console.Write("Informe a quantidade de dezenas: ");
    if (int.TryParse(Console.ReadLine(), out qntDezenas) && qntDezenas >= 6 && qntDezenas <= 15)
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A quantidade de dezenas precisa estar entre 6 e 15. Tente novamente.");
        Console.ResetColor();
    }
}

Console.WriteLine("Suas dezenas sorteadas foram:");

Random aleatorio = new Random();

for (int j = 1; j <= qntJogos; j++)
{
    for (int d = 1; d <= qntDezenas; d++)
    {
        int dezena = aleatorio.Next(1, 61);
        if (d != qntDezenas)
        {
            Console.Write($"{dezena:D2}-");
        }
        else
        {
            Console.Write($"{dezena:D2}\n");
        }
    }
}

decimal premioTotal;

Console.WriteLine();
while (true)
{

    Console.Write("Informe o valor total do prêmio: R$ ");
    if (decimal.TryParse(Console.ReadLine(), out premioTotal) && premioTotal > 0)
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, insira um número maior que 0.");
        Console.ResetColor();
    }
}

decimal premio6Dzn = premioTotal * .75m;
decimal premio5Dzn = premioTotal * .15m;
decimal premio4Dzn = premioTotal * .10m;

Console.WriteLine($"Serão:");
Console.WriteLine($"\t- {premio6Dzn:C} distribuídos aos que acertarem 6 dezenas (Sena)");
Console.WriteLine($"\t- {premio5Dzn:C} distribuídos aos que acertarem 5 dezenas (Quina)");
Console.WriteLine($"\t- {premio4Dzn:C} distribuídos aos que acertarem 4 dezenas (Quadra)");