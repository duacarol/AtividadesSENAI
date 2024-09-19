Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=".PadLeft(31, '='));
Console.WriteLine("Verificador de Número Par-Ímpar");
Console.WriteLine("=".PadLeft(31, '='));
Console.ResetColor();

int numero;
bool numeroValido;

do
{
    Console.Write("Informe um número: ");
    numeroValido = int.TryParse(Console.ReadLine(), out numero);

    if (!numeroValido)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Por favor, insira um número inteiro.");
        Console.ResetColor();
    }
} while (!numeroValido);

if (numero % 2 == 0)
    Console.WriteLine("O número informado é par.");
else
    Console.WriteLine("O número informado é ímpar.");