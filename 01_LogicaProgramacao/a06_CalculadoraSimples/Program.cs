Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("=".PadLeft(18, '='));
Console.WriteLine("Calculadora Básica");
Console.WriteLine("=".PadLeft(18, '='));
Console.ResetColor();

double numero1, numero2;
bool entradaValida;

do
{
    Console.Write("Digite o primeiro número: ");
    entradaValida = double.TryParse(Console.ReadLine(), out numero1);

    if (!entradaValida)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Número inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (!entradaValida);

do
{
    Console.Write("Digite o segundo número: ");
    entradaValida = double.TryParse(Console.ReadLine(), out numero2);

    if (!entradaValida)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Número inválido. Tente novamente.");
        Console.ResetColor();
    }
} while (!entradaValida);

string operacao;
double resultado = 0;
entradaValida = false;

do
{
    Console.Write("Escolha uma operação (+, -, *, /): ");
    operacao = Console.ReadLine();

    switch (operacao)
    {
        case "+":
            resultado = numero1 + numero2;
            entradaValida = true;
            break;
        case "-":
            resultado = numero1 - numero2;
            entradaValida = true;
            break;
        case "*":
            resultado = numero1 * numero2;
            entradaValida = true;
            break;
        case "/":
            if (numero2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe divisão por zero. Tente novamente.");
                Console.ResetColor();
            }
            else
            {
                resultado = numero1 / numero2;
                entradaValida = true;
            }
            break;
        default:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Operação inválida. Tente novamente.");
                Console.ResetColor();
            }
            break;
    }
} while (!entradaValida);

Console.WriteLine($"O resultado é: {Math.Round(resultado, 2)}.");