Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("=".PadLeft(32, '='));
Console.WriteLine("Cálculo de Imposto sobre Salário");
Console.WriteLine("=".PadLeft(32, '='));
Console.ResetColor();

Console.Write("Informe o salário: R$ ");
if (decimal.TryParse(Console.ReadLine(), out decimal salario))
{
    decimal valorImposto;
    string por100Imposto;

    if (salario <= 3000)
    {
        valorImposto = salario * .1m;
        por100Imposto = "10%";
    }

    else if (salario <= 6000)
    {
        valorImposto = salario * .15m;
        por100Imposto = "15%";
    }

    else
    {
        valorImposto = salario * .2m;
        por100Imposto = "20%";
    }
    Console.WriteLine($"O imposto aplicado ao salário será de {por100Imposto}, o equivalente a {valorImposto:C}.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O valor inserido não é um número. Tente novamente.");
    Console.ResetColor();
}