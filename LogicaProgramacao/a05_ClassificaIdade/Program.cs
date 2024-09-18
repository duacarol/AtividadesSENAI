
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(22, '='));
Console.WriteLine("Classificação de Idade");
Console.WriteLine("=".PadLeft(22, '='));
Console.ResetColor();

int idade;
bool idadeValida;

do
{
    Console.Write("Informe sua idade: ");
    idadeValida = int.TryParse(Console.ReadLine(), out idade) && idade >= 0;
    if (!idadeValida)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Apenas números naturais são aceitos.");
        Console.ResetColor();
    }
} while (!idadeValida);

if (idade <= 12)
    Console.WriteLine("Você é uma criança.");

else if (idade <= 17)
    Console.WriteLine("Você é um adolescente.");

else if (idade <= 64)
    Console.WriteLine("Você é um adulto.");

else
    Console.WriteLine("Você é um idoso.");