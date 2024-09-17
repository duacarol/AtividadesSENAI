
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=".PadLeft(26, '='));
Console.WriteLine("Contador de Letra em Texto");
Console.WriteLine("=".PadLeft(26, '='));
Console.ResetColor();

Console.Write("Insira o texto: ");
string texto = Console.ReadLine().ToUpper();

while (true)
{
    Console.Write("Insira a letra que deseja contar: ");

    if (char.TryParse(Console.ReadLine().ToUpper(), out char letra) && char.IsLetter(letra))
    {
        int contagem = 0;
        foreach (char c in texto)
        {
            if (c == letra)
                contagem++;
        }

        Console.WriteLine($"A letra '{letra}' aparece {contagem} vez(es) neste texto.");
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O caractere inserido não é uma letra. Tente novamente.");
        Console.ResetColor();
    }
}