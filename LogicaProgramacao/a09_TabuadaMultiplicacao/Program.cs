Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=".PadLeft(23, '='));
Console.WriteLine("Tabuada de Multiplicação");
Console.WriteLine("=".PadLeft(23, '='));
Console.ResetColor();

int numero1;
bool entradaValida;

do
{
    Console.Write("Insira um número: ");
    entradaValida = int.TryParse(Console.ReadLine(), out numero1);

    if (!entradaValida)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Por favor, insira um número inteiro.");
        Console.ResetColor();
    }

} while (!entradaValida);

for (int numero2 = 1; numero2 <= 10; numero2++)
{
    int resultado = numero1 * numero2;
    Console.WriteLine($"{numero1} × {numero2} = {resultado}");
}