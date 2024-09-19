Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(new string('=', 30));
Console.WriteLine("Verificador de Vogal-Consoante");
Console.WriteLine(new string('=', 30));
Console.ResetColor();

char letra;
char[] vogais = {
    'A', 'Á', 'À', 'Â', 'Ã', 'Ä',
    'E', 'É', 'È', 'Ê', 'Ẽ', 'Ë',
    'I', 'Í', 'Ì', 'Î', 'Ĩ', 'Ï',
    'O', 'Ó', 'Ò', 'Ô', 'Õ', 'Ö',
    'U', 'Ú', 'Ù', 'Û', 'Ũ', 'Ü'
};

while (true)
{
    Console.Write("Insira uma letra: ");
    if (char.TryParse(Console.ReadLine().ToUpper(), out letra) && char.IsLetter(letra))
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("O valor inserido não é uma letra válida (alfabeto latino). Tente novamente.");
        Console.ResetColor();
    }
}

bool ehVogal = false;

foreach (char v in vogais)
{
    if (v == letra)
        ehVogal = true;
}

if (ehVogal)
    Console.WriteLine($"A letra '{letra}' é uma vogal.");
else
    Console.WriteLine($"A letra '{letra}' é uma consoante.");