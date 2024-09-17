Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=".PadLeft(18, '='));
Console.WriteLine("Conversor de Moeda");
Console.WriteLine("=".PadLeft(18, '='));
Console.ResetColor();

double real;
bool valorValido;

do
{
    Console.Write("Insira o valor em reais: R$ ");

    valorValido = double.TryParse(Console.ReadLine(), out real) && real > 0;

    if (!valorValido)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Por favor, insira um número maior do que 0.");
        Console.ResetColor();
    }

} while (!valorValido);

double dolar = 5.48, euro = 6.09, libra = 7.14;

Console.WriteLine("Resultado da conversão para:");
Console.WriteLine($"\t- Dólar: US$ {(real / dolar):0.00}");
Console.WriteLine($"\t- Euro: € {(real / euro):0.00}");
Console.WriteLine($"\t- Libra: £ {(real / libra):0.00}");