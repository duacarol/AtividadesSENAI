Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("=".PadLeft(28, '='));
Console.WriteLine("Sistema de Avaliação Escolar");
Console.WriteLine("=".PadLeft(28, '='));
Console.ResetColor();

int nota;
bool notaValida;

do
{
    Console.Write("Insira a nota do aluno: ");    
    notaValida = int.TryParse(Console.ReadLine(), out nota) && nota > 0;
    if(!notaValida)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Apenas números naturais são aceitos.");
        Console.ResetColor();
    }
} while (!notaValida);

if (nota >= 10)
    Console.WriteLine($"O aluno está aprovado.");
else if (nota >= 5)
    Console.WriteLine($"O aluno está de recuperação.");
else
    Console.WriteLine($"O aluno está reprovado.");