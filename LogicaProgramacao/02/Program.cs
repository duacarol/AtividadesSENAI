Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=".PadLeft(28, '='));
Console.WriteLine("Calculadora de Média Escolar");
Console.WriteLine("=".PadLeft(28, '='));
Console.ResetColor();

double soma = 0;

for (int i = 1; i <= 4; i++)
{
    double nota;
    bool notaValida;

    do
    {
        Console.Write($"Insira a {i}ª nota (de 0 a 100): ");
        notaValida = double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100;
        if (!notaValida)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor inválido. Por favor, insira um número de 0 a 100.");
            Console.ResetColor();
        }
    } while (!notaValida);

    soma += nota;
}

double media = soma / 4;

if (media >= 60)
    Console.WriteLine($"O aluno está aprovado com média {media:F2}.");
else if (media >= 40)
    Console.WriteLine($"O aluno está de recuperação com média {media:F2}.");
else
    Console.WriteLine($"O aluno está reprovado com média {media:F2}.");