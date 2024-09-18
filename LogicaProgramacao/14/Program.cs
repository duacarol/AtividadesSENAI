Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("=".PadLeft(19, '='));
Console.WriteLine("Conversor de Medida");
Console.WriteLine("=".PadLeft(19, '='));
Console.ResetColor();

double distancia;
bool numeroValido;

do
{
    Console.Write("Insira a distância em metros: ");
    numeroValido = double.TryParse(Console.ReadLine(), out distancia) && distancia > 0;

    if (!numeroValido)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido. Por favor, insira um número maior do que 0.");
        Console.ResetColor();
    }
} while (!numeroValido);

Console.Write("Escolha a unidade de conversão (cm, km, mi): ");
switch (Console.ReadLine().ToLower())
{
    case "cm":
        Console.WriteLine($"{distancia:F2} m é igual a {distancia * 100:F2} cm.");
        break;
    case "km":
        Console.WriteLine($"{distancia:F2} m é igual a {distancia / 1000:F2} km.");
        break;
    case "mi":
        Console.WriteLine($"{distancia:F2} m é igual a {distancia * 0.000621371:F2} mi.");
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida. Por favor, escolha entre cm, km ou mi.");
        Console.ResetColor();
        break;
}