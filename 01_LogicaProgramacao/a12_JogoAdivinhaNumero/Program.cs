Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(new string('=', 19));
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine(new string('=', 19));
Console.ResetColor();

Random aleatorio = new Random();
int palpite = 0, tentativas = 0, numeroAleatorio = aleatorio.Next(1, 101);

Console.WriteLine("Boas-vindas ao Jogo de Adivinhação!");
Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

while (palpite != numeroAleatorio)
{
    tentativas++;
    bool entradaValida = false;

    while (!entradaValida)
    {
        Console.Write("Digite o seu palpite: ");
        if (int.TryParse(Console.ReadLine(), out palpite))
        {
            if (palpite >= 1 && palpite <= 100)
            {
                entradaValida = true;

                if (palpite < numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Muito baixo. Tente um número maior.");
                    Console.ResetColor();
                }
                else if (palpite > numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Muito alto. Tente um número menor.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você acertou: {numeroAleatorio}!");
                    Console.ResetColor();
                    Console.WriteLine($"Número de tentativas: {tentativas}.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O número precisa estar entre 1 e 100. Tente novamente.");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            Console.ResetColor();
        }
    }
}