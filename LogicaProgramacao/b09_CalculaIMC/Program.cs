Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(new string('=', 18));
Console.WriteLine("Calculadora de IMC");
Console.WriteLine(new string('=', 18));
Console.ResetColor();

double peso;
double altura;

while (true)
{
    Console.Write("Informar o peso (kg): ");
    if (double.TryParse(Console.ReadLine(), out peso) && peso > 0)
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Tente novamente.");
        Console.ResetColor();
    }
}

while (true)
{
    Console.Write("Informar a altura (m): ");
    if (double.TryParse(Console.ReadLine(), out altura) && altura > 0)
        break;
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Tente novamente.");
        Console.ResetColor();
    }
}

double imc = peso / (altura * altura);

Console.WriteLine("Possui algum dos problemas listados abaixo?");
Console.WriteLine("\t1. Diabetes");
Console.WriteLine("\t2. Problemas nas articulações (Ex.: artrite)");
Console.WriteLine("\t3. Problemas cardíacos");
Console.WriteLine("\t4. Obesidade");
Console.WriteLine("\t5. Dores nas costas");
Console.WriteLine("\t6. Ansiedade ou estresse");
Console.WriteLine("\t0. Não possuo");

List<string> problemasValidos = new List<string> { "0", "1", "2", "3", "4", "5", "6" };
List<string> problemas = new List<string>();

while (true)
{
    Console.Write("Escolha uma ou mais opções (separar por vírgula): ");
    string[] entradas = Console.ReadLine().Split(',');

    bool entradasValidas = true;

    foreach (string entrada in entradas)
    {
        string problema = entrada.Trim();
        if (!problemasValidos.Contains(problema))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção ou opções inválida(s). Tente novamente.");
            Console.ResetColor();
            entradasValidas = false;
            break;
        }
        problemas.Add(problema);
    }
    
    if (entradasValidas)
        break;
}

Console.Clear();

if (imc <= 29.9 && problemas.Contains("4"))
    Console.Write("Tem certeza que tem obesidade? ");
if (imc < 18.5)
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado abaixo do peso.");
else if (imc >= 18.5 && imc <= 24.9)
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado peso normal.");
else if (imc >= 25 && imc <= 29.9)
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado sobrepeso.");
else if (imc >= 30 && imc <= 34.9)
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado obesidade leve.");
else if (imc >= 35 && imc <= 39.9)
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado obesidade moderada.");
else
    Console.WriteLine($"Seu IMC é {Math.Round(imc, 2)}, considerado obesidade mórbida.");

if (imc >= 30 && !problemas.Contains("4"))
{
    Console.WriteLine("\nSugestões de exercícios para obesidade:");
    Console.WriteLine("\t· Caminhadas e caminhadas rápidas");
    Console.WriteLine("\t· Natação");
    Console.WriteLine("\t· Exercícios em bicicleta ergométrica");
    Console.WriteLine("\t· Exercícios aeróbicos de baixo impacto");
    Console.WriteLine("\t· Hidroginástica");
}

foreach (string problema in problemas)
{
    switch (problema)
    {
        case "1":
            Console.WriteLine("\nSugestões de exercícios para diabetes:");
            Console.WriteLine("\t· Caminhadas rápidas");
            Console.WriteLine("\t· Natação");
            Console.WriteLine("\t· Treinamento de resistência (com pesos leves a moderados)");
            Console.WriteLine("\t· Exercícios aeróbicos de baixa intensidade");
            Console.WriteLine("\t· Yoga (ajuda no controle do estresse e glicemia)");
            break;
        case "2":
            Console.WriteLine("\nSugestões de exercícios para problemas nas articulações:");
            Console.WriteLine("\t· Hidroginástica");
            Console.WriteLine("\t· Caminhadas leves");
            Console.WriteLine("\t· Ciclismo (com baixa resistência)");
            Console.WriteLine("\t· Alongamentos e yoga");
            Console.WriteLine("\t· Pilates (fortalecimento sem sobrecarga articular)");
            break;
        case "3":
            Console.WriteLine("\nSugestões de exercícios para problemas cardíacos:");
            Console.WriteLine("\t· Caminhadas moderadas");
            Console.WriteLine("\t· Bicicleta leve");
            Console.WriteLine("\t· Natação");
            Console.WriteLine("\t· Exercícios de alongamento");
            Console.WriteLine("\t· Tai Chi (uma forma de exercício suave que também ajuda com equilíbrio)");
            break;
        case "4":
            Console.WriteLine("\nSugestões de exercícios para obesidade:");
            Console.WriteLine("\t· Caminhadas e caminhadas rápidas");
            Console.WriteLine("\t· Natação");
            Console.WriteLine("\t· Exercícios em bicicleta ergométrica");
            Console.WriteLine("\t· Exercícios aeróbicos de baixo impacto");
            Console.WriteLine("\t· Hidroginástica");
            break;
        case "5":
            Console.WriteLine("\nSugestões de exercícios para dores nas costas:");
            Console.WriteLine("\t· Caminhada em ritmo leve");
            Console.WriteLine("\t· Natação ou hidroginástica");
            Console.WriteLine("\t· Yoga com foco em alongamento e fortalecimento do núcleo");
            Console.WriteLine("\t· Pilates (fortalecimento do núcleo)");
            Console.WriteLine("\t· Exercícios de alongamento e mobilidade");
            break;
        case "6":
            Console.WriteLine("\nSugestões de exercícios para ansiedade ou estresse:");
            Console.WriteLine("\t· Yoga");
            Console.WriteLine("\t· Tai Chi");
            Console.WriteLine("\t· Meditação guiada (combinada com alongamentos)");
            Console.WriteLine("\t· Caminhadas ao ar livre");
            Console.WriteLine("\t· Dança (para liberar endorfina)");
            break;
    }
}
